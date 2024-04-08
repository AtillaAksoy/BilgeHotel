using BilgeHotel.Application.Features.Room.Commands.Delete;
using BilgeHotel.Application.Repositories.RoomRepositories;
using BilgeHotel.Application.Repositories.ShiftRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Commands.Delete
{
    public class DeleteShiftCommandHandler : IRequestHandler<DeleteShiftCommandRequest, DeleteShiftCommandResponse>
    {
        private readonly IShiftWriteRepository _shiftWriteRepository;
        private readonly IShiftReadRepository _shiftReadRepository;
        public DeleteShiftCommandHandler(IShiftWriteRepository shiftWriteRepository, IShiftReadRepository shiftReadRepository)
        {
            _shiftWriteRepository = shiftWriteRepository;
            _shiftReadRepository = shiftReadRepository;
        }
        public async Task<DeleteShiftCommandResponse> Handle(DeleteShiftCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _shiftReadRepository.GetByIdAsync(request.Id);
            if (entity == null) { return new DeleteShiftCommandResponse { Message = "bulunamadı" }; }
            entity.IsDeleted = true;
            entity.IsPassive = true;
            var update = await _shiftWriteRepository.Update(entity);
            var save = await _shiftWriteRepository.SaveAsync();
            if (save == 0)
            {
                return new DeleteShiftCommandResponse { Message = "kaydederken hata" };
            }
            if (update)
            {
                return new DeleteShiftCommandResponse { Message = "Silme işlemi başarılı" };
            }
            return new DeleteShiftCommandResponse { Message = "eklerken hata" };
        }
    }
}
