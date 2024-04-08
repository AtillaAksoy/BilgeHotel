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
    public class RoomTypeWriteRepository : WriteRepository<RoomType>, IRoomTypeWriteRepository
    {
        public RoomTypeWriteRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
