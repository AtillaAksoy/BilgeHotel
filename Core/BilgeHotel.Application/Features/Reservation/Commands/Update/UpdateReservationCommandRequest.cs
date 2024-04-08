using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.Update
{
    public class UpdateReservationCommandRequest : IRequest<UpdateReservationCommandResponse>
    {
        public ReservationDto Reservation { get; set; }
    }
}
