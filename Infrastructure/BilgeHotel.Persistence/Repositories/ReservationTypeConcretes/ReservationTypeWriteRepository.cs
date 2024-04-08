using BilgeHotel.Application.Repositories.ReservationTypeRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.ReservationTypeConcretes
{
    public class ReservationTypeWriteRepository : WriteRepository<ReservationType>, IReservationTypeWriteRepository
    {
        public ReservationTypeWriteRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
