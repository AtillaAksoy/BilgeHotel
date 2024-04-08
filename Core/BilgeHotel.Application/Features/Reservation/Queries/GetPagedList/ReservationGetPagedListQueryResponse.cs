using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Queries.GetPagedList
{
    public class ReservationGetPagedListQueryResponse :ResponseParameters
    {
        public List<ReservationDto>? Reservations { get; set; }
    }
}
