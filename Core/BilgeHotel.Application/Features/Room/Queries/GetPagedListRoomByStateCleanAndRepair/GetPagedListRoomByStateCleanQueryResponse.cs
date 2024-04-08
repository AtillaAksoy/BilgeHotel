using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Queries.GetPagedListRoomByStateClean
{
    public class GetPagedListRoomByStateCleanQueryResponse : ResponseParameters
    {
        public List<RoomDto>? rooms { get; set; }
    }
}
