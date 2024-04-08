using BilgeHotel.Application.Repositories.ReservationRepositories;
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
    public class ReservationStateReadRepository : ReadRepository<ReservationState>, IReservationStateReadRepository
    {
        public ReservationStateReadRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
