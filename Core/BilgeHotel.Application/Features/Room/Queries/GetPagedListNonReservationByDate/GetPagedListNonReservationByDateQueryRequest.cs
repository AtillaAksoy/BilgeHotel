using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Queries.GetPagedListNonReservationByDate
{
    public class GetPagedListNonReservationByDateQueryRequest : DtParameters , IRequest<GetPagedListNonReservationByDateQueryResponse>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
