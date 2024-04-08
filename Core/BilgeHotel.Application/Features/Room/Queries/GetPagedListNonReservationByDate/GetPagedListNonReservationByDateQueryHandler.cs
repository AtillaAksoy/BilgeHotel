using BilgeHotel.Application.Repositories.RoomRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Queries.GetPagedListNonReservationByDate
{
    public class GetPagedListNonReservationByDateQueryHandler : IRequestHandler<GetPagedListNonReservationByDateQueryRequest, GetPagedListNonReservationByDateQueryResponse>
    {
        private readonly IRoomReadRepository _roomReadRepository;
        public GetPagedListNonReservationByDateQueryHandler(IRoomReadRepository roomReadRepository)
        {
            _roomReadRepository = roomReadRepository;
        }
        public async Task<GetPagedListNonReservationByDateQueryResponse> Handle(GetPagedListNonReservationByDateQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _roomReadRepository.GetAllPagedListByDate(request);
            return response;
        }
    }
}
