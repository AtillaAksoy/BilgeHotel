using BilgeHotel.Domain.Entities.Common;

namespace BilgeHotel.Domain.Entities
{
    public class WorkType:BaseEntity
    {
        //createddate ignorlanacak
        public string Name { get; set; } //sabah 1/3  veya öğen 1/3  veya sabah 1/2 yada 8-16
        public string? Description { get; set; }

        public ICollection<Shift>? Shifts { get; set; }
    }
}