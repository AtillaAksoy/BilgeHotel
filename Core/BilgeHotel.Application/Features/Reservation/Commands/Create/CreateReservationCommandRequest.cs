using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.Create
{
    public class CreateReservationCommandRequest : IRequest<CreateReservationCommandResponse>
    {
        public ReservationDto Reservation { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
