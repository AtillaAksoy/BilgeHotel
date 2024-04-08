using BilgeHotel.Application.Features.Room.Commands.Update;
using BilgeHotel.Application.Repositories.RoomRepositories;
using BilgeHotel.Application.Repositories.ShiftRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Commands.Update
{
    public class UpdateShiftCommandHandler : IRequestHandler<UpdateShiftCommandRequest, UpdateShiftCommandResponse>
    {
        private readonly IShiftWriteRepository _shiftWriteRepository;
        public UpdateShiftCommandHandler(IShiftWriteRepository shiftWriteRepository)
        {
            _shiftWriteRepository = shiftWriteRepository;
        }
        public async Task<UpdateShiftCommandResponse> Handle(UpdateShiftCommandRequest request, CancellationToken cancellationToken)
        {
            var shift = request.Shift.Adapt<Domain.Entities.Shift>();
            var update = await _shiftWriteRepository.Update(shift);
            var save = await _shiftWriteRepository.SaveAsync();
            if (save == 0)
            {
                return new UpdateShiftCommandResponse { Message = "kaydederken hata" };
            }
            if (update)
            {
                return new UpdateShiftCommandResponse { Message = "başarılı" };
            }
            return new UpdateShiftCommandResponse { Message = "eklerken hata" };
        }
    }
}
