using BilgeHotel.Application.Repositories.RoomTypeRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.RoomTypeConcretes
{
    public class RoomTypeReadRepository : ReadRepository<RoomType>, IRoomTypeReadRepository
    {
        public RoomTypeReadRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
