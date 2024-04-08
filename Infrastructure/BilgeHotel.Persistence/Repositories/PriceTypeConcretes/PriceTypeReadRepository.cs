using BilgeHotel.Application.Repositories.PriceTypeRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.PriceTypeConcretes
{
    public class PriceTypeReadRepository : ReadRepository<PriceType>, IPriceTypeReadRepositories
    {
        public PriceTypeReadRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
