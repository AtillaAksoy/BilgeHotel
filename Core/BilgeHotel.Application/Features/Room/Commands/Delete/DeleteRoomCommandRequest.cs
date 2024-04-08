using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Commands.Delete
{
    public class DeleteRoomCommandRequest : IRequest<DeleteRoomCommandResponse>
    {
        public int Id { get; set; }
    }
}
