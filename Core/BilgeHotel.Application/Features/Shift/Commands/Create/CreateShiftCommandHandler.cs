using BilgeHotel.Application.Features.Room.Commands.Create;
using BilgeHotel.Application.Repositories.RoomRepositories;
using BilgeHotel.Application.Repositories.ShiftRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Commands.Create
{
    public class CreateShiftCommandHandler : IRequestHandler<CreateShiftCommandRequest, CreateShiftCommandResponse>
    {
        private readonly IShiftWriteRepository _shiftWriteRepository;
        public CreateShiftCommandHandler(IShiftWriteRepository shiftWriteRepository)
        {
            _shiftWriteRepository = shiftWriteRepository;
        }
        public async Task<CreateShiftCommandResponse> Handle(CreateShiftCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var shift = request.Shift.Adapt<Domain.Entities.Shift>();
                var added = await _shiftWriteRepository.AddAsync(shift);
                var save = await _shiftWriteRepository.SaveAsync();

                if (added)
                {
                    return new CreateShiftCommandResponse { Message = "İşlem Başarılı" };
                }
                if (save == 0)
                {
                    return new CreateShiftCommandResponse { Message = "kaydederken hata" };
                }
                return new CreateShiftCommandResponse { Message = "oluşturulurken hata" };
            }
            catch (Exception ex)
            {
                return new CreateShiftCommandResponse { Message = $"Hata {ex.Message}" };
            }

        }
    }
}
