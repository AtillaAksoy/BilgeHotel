using BilgeHotel.Domain.Entities.Common;

namespace BilgeHotel.Domain.Entities
{
    public class PriceType:BaseEntity
    {
        public string Name { get; set; }

        public ICollection<EmployeePrice>? employeePrices { get; set; }
    }
}