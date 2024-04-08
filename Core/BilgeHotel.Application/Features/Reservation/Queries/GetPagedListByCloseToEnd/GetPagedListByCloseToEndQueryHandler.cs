using BilgeHotel.Application.Repositories.ReservationRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Queries.GetPagedListByCloseToEnd
{
    public class GetPagedListByCloseToEndQueryHandler : IRequestHandler<GetPagedListByCloseToEndQueryRequest, GetPagedListByCloseToEndQueryResponse>
    {
        private readonly IReservationReadRepository _reservationReadRepository;
        public GetPagedListByCloseToEndQueryHandler(IReservationReadRepository reservationReadRepository)
        {
            _reservationReadRepository = reservationReadRepository;
        }
        public async Task<GetPagedListByCloseToEndQueryResponse> Handle(GetPagedListByCloseToEndQueryRequest request, CancellationToken cancellationToken)
        {
            var reservations = await _reservationReadRepository.GetAllPagedListByCloseToEnd(request);
            return reservations;
        }
    }
}
