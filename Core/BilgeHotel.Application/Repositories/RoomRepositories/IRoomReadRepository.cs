using BilgeHotel.Application.Features.Room.Queries.GetPagedList;
using BilgeHotel.Application.Features.Room.Queries.GetPagedListNonReservationByDate;
using BilgeHotel.Application.Features.Room.Queries.GetPagedListRoomByStateClean;
using BilgeHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories.RoomRepositories
{
    public interface IRoomReadRepository : IReadRepository<Room>
    {
        Task<RoomGetPagedListQueryResponse> GetAllPagedList(RoomGetPagedListQueryRequest request);
        Task<GetPagedListNonReservationByDateQueryResponse> GetAllPagedListByDate(GetPagedListNonReservationByDateQueryRequest request);

        Task<GetPagedListRoomByStateCleanQueryResponse> GetAllPagedListByState(GetPagedListRoomByStateCleanQueryRequest request);
    }
}
