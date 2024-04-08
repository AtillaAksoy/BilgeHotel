using BilgeHotel.Application.Repositories.RoomStateRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.RoomStateConcretes
{
    public class RoomStateReadRepository : ReadRepository<RoomState>, IRoomStateReadRepository
    {
        public RoomStateReadRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
