using BilgeHotel.Domain.Entities.Common;

namespace BilgeHotel.Domain.Entities
{
    public class RoomState:BaseEntity
    {
        public string State { get; set; }
        public string? Note { get; set; }

        //Mapping
        public virtual ICollection<Room>? Rooms { get; set; }
    }
}