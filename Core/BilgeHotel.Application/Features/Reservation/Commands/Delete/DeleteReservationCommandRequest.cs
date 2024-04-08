using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.Delete
{
    public class DeleteReservationCommandRequest : IRequest<DeleteReservationCommandResponse>
    {
        public int Id {  get; set; }
    }
}
