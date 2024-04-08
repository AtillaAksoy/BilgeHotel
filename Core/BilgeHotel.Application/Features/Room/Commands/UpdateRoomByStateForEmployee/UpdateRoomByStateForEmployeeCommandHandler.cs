using BilgeHotel.Application.Repositories.RoomRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Commands.UpdateRoomByStateForEmployee
{
    public class UpdateRoomByStateForEmployeeCommandHandler : IRequestHandler<UpdateRoomByStateForEmployeeCommandRequest, UpdateRoomByStateForEmployeeCommandResponse>
    {
        private readonly IRoomWriteRepository _roomWriteRepository;
        private readonly IRoomReadRepository _roomReadRepository;
        public UpdateRoomByStateForEmployeeCommandHandler(IRoomWriteRepository roomWriteRepository, IRoomReadRepository roomReadRepository)
        {
            _roomWriteRepository = roomWriteRepository;
            _roomReadRepository = roomReadRepository;
        }
        public async Task<UpdateRoomByStateForEmployeeCommandResponse> Handle(UpdateRoomByStateForEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
             var room = await _roomReadRepository.GetByIdAsync(request.RoomId);
            if (room == null) { return new UpdateRoomByStateForEmployeeCommandResponse { Message = "oda bulunamadı" }; }
            room.RoomStateId = request.StateId;
            var updated = await _roomWriteRepository.Update(room);
            var save = await _roomWriteRepository.SaveAsync();
            if (updated)
            {
                return new UpdateRoomByStateForEmployeeCommandResponse { Message = "başarılı" };
            }
            if (save == 0)
            {
                return new UpdateRoomByStateForEmployeeCommandResponse { Message = "kaydederken hata" };
            }
            return new UpdateRoomByStateForEmployeeCommandResponse { Message = "hata" };
        }
    }
}
