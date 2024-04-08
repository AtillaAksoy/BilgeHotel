using BilgeHotel.Application.Repositories.RoomRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Commands.Update
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommandRequest, UpdateRoomCommandResponse>
    {
        private readonly IRoomWriteRepository _roomWriteRepository;
        public UpdateRoomCommandHandler(IRoomWriteRepository roomWriteRepository)
        {
            _roomWriteRepository = roomWriteRepository;
        }
        public async Task<UpdateRoomCommandResponse> Handle(UpdateRoomCommandRequest request, CancellationToken cancellationToken)
        {
            var room = request.Room.Adapt<Domain.Entities.Room>();
            var update = await _roomWriteRepository.Update(room);
            var save = await _roomWriteRepository.SaveAsync();
            if (save == 0)
            {
                return new UpdateRoomCommandResponse { Message = "kaydederken hata" };
            }
            if (update)
            {
                return new UpdateRoomCommandResponse { Message = "başarılı" };
            }
            return new UpdateRoomCommandResponse { Message = "eklerken hata" };
        }
    }
}
