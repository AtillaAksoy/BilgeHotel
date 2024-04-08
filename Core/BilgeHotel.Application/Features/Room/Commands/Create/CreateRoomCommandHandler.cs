using BilgeHotel.Application.Repositories.RoomRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Commands.Create
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommandRequest, CreateRoomCommandResponse>
    {
        private readonly IRoomWriteRepository _roomWriteRepository;
        public CreateRoomCommandHandler(IRoomWriteRepository roomWriteRepository)
        {
            _roomWriteRepository = roomWriteRepository;
        }
        public async Task<CreateRoomCommandResponse> Handle(CreateRoomCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var room = request.room.Adapt<Domain.Entities.Room>();
                var added = await _roomWriteRepository.AddAsync(room);
                var save = await _roomWriteRepository.SaveAsync();
               
                if (added)
                {
                    return new CreateRoomCommandResponse { Message = "İşlem Başarılı" };
                }
                if (save == 0)
                {
                    return new CreateRoomCommandResponse { Message = "kaydederken hata" };
                }
                return new CreateRoomCommandResponse { Message = "oluşturulurken hata" };
            }
            catch (Exception ex)
            {
                return new CreateRoomCommandResponse { Message = "Hata" };
            }
            
        }
    }
}
