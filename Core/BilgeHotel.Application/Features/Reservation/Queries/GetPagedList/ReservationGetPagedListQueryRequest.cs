using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Queries.GetPagedList
{
    public class ReservationGetPagedListQueryRequest : DtParameters, IRequest<ReservationGetPagedListQueryResponse>
    {
    }
}
