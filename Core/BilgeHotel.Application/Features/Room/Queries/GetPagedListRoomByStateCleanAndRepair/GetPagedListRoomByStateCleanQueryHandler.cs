using BilgeHotel.Application.Repositories.RoomRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Queries.GetPagedListRoomByStateClean
{
    public class GetPagedListRoomByStateCleanQueryHandler : IRequestHandler<GetPagedListRoomByStateCleanQueryRequest, GetPagedListRoomByStateCleanQueryResponse>
    {
        private readonly IRoomReadRepository _roomReadRepository;
        public GetPagedListRoomByStateCleanQueryHandler(IRoomReadRepository roomReadRepository)
        {
            _roomReadRepository = roomReadRepository;
        }

        public async Task<GetPagedListRoomByStateCleanQueryResponse> Handle(GetPagedListRoomByStateCleanQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _roomReadRepository.GetAllPagedListByState(request); //Expression method eklenecek
            return response;
        }
    }
}
