using BilgeHotel.Domain.Entities.Common;

namespace BilgeHotel.Domain.Entities
{
    public class ReservationState:BaseEntity
    {
        public string StateName { get; set; }
        public string Description { get; set; }

        //Mapping
        public ICollection<Reservation>? Reservations { get; set; }
    }
}