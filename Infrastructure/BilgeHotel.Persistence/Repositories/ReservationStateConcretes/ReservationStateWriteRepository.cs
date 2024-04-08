using BilgeHotel.Application.Repositories.ReservationStateRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.ReservationStateConcretes
{
    public class ReservationStateWriteRepository : WriteRepository<ReservationState>, IReservationStateWriteRepository
    {
        public ReservationStateWriteRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
