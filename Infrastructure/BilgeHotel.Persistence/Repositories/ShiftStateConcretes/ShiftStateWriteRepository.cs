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
    public class ShiftStateWriteRepository : WriteRepository<ShiftState>, IShiftStateWriteRepository
    {
        public ShiftStateWriteRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
