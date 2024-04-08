using BilgeHotel.Domain.Entities.Common;

namespace BilgeHotel.Domain.Entities
{
    public class ReservationType:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Mapping
        public ICollection<Reservation>? Reservations { get; set; }
    }
}