using BilgeHotel.Domain.Entities.Common;

namespace BilgeHotel.Domain.Entities
{
    public class ShiftState:BaseEntity
    {
        //createddate propertisy ignore edilecek
        public string Name { get; set; }
        public string Description { get; set; }
       
        public ICollection<Shift>? Shifts { get; set; }
    }
}