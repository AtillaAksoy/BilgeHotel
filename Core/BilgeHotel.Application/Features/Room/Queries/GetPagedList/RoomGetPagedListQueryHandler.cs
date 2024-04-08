using BilgeHotel.Application.Repositories.RoomRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Queries.GetPagedList
{
    public class RoomGetPagedListQueryHandler : IRequestHandler<RoomGetPagedListQueryRequest, RoomGetPagedListQueryResponse>
    {
        private readonly IRoomReadRepository _roomReadRepository;
        public RoomGetPagedListQueryHandler(IRoomReadRepository roomReadRepository)
        {
            _roomReadRepository = roomReadRepository;
        }
        public async Task<RoomGetPagedListQueryResponse> Handle(RoomGetPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _roomReadRepository.GetAllPagedList(request);
            return response;
        }
    }
}
