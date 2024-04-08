using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Commands.Update
{
    public class UpdateRoomCommandRequest : IRequest<UpdateRoomCommandResponse>
    {
        public RoomDto Room { get; set; }
    }
}
