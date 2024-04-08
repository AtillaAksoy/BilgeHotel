using BilgeHotel.Application.Repositories.ReservationRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Queries.GetPagedList
{
    public class ReservationGetPagedListQueryHandler : IRequestHandler<ReservationGetPagedListQueryRequest, ReservationGetPagedListQueryResponse>
    {
        private readonly IReservationReadRepository _reservationReadRepository;
        public ReservationGetPagedListQueryHandler(IReservationReadRepository reservationReadRepository)
        {
            _reservationReadRepository = reservationReadRepository;
        }
        public async Task<ReservationGetPagedListQueryResponse> Handle(ReservationGetPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var reservations = await _reservationReadRepository.GetAllPagedList(request);
            return reservations;
        }
    }
}
