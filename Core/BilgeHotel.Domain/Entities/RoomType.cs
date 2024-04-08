using BilgeHotel.Domain.Entities.Common;

namespace BilgeHotel.Domain.Entities
{
    public class RoomType:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //mapping
        public virtual ICollection<Room>? Rooms { get; set; }
    }
}