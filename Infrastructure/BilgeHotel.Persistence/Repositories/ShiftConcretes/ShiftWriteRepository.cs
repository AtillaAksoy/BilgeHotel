using BilgeHotel.Application.Repositories.ShiftRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.ShiftConcretes
{
    public class ShiftWriteRepository : WriteRepository<Shift>, IShiftWriteRepository
    {
        public ShiftWriteRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
