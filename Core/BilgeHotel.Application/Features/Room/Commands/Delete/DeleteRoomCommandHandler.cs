using BilgeHotel.Application.Repositories.RoomRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Commands.Delete
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommandRequest, DeleteRoomCommandResponse>
    {
        private readonly IRoomWriteRepository _roomWriteRepository;
        private readonly IRoomReadRepository _roomReadRepository;
        public DeleteRoomCommandHandler(IRoomWriteRepository roomWriteRepository, IRoomReadRepository roomReadRepository)
        {
            _roomWriteRepository = roomWriteRepository;
            _roomReadRepository = roomReadRepository;
        }
        public async Task<DeleteRoomCommandResponse> Handle(DeleteRoomCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _roomReadRepository.GetByIdAsync(request.Id);
            if (entity == null) { return new DeleteRoomCommandResponse { Message = "bulunamadı" }; }
            entity.IsDeleted = true;
            entity.IsActive = false;
            entity.IsPassive = true;
            var update = await _roomWriteRepository.Update(entity);
            var save = await _roomWriteRepository.SaveAsync();
            if (save == 0)
            {
                return new DeleteRoomCommandResponse { Message = "kaydederken hata" };
            }
            if (update)
            {
                return new DeleteRoomCommandResponse { Message = "Silme işlemi başarılı" };
            }
            return new DeleteRoomCommandResponse { Message = "eklerken hata" };
        }
    }
}
