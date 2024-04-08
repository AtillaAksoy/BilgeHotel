using BilgeHotel.Domain.Entities.Common;
using BilgeHotel.Domain.Entities.Identity;

namespace BilgeHotel.Domain.Entities
{
    public class EmployeePrice : BaseEntity
    {
        public Decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int PriceTypeId { get; set; }
        public PriceType PriceType { get; set; }
                      //?
    }
}
