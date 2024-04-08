using BilgeHotel.Application.Repositories.ShiftStateRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.ShiftStateConcretes
{
    public class ShiftStateReadRepository : ReadRepository<ShiftState>, IShiftStateReadRepository
    {
        public ShiftStateReadRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
