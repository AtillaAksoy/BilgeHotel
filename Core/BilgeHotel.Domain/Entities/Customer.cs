using BilgeHotel.Domain.Entities.Common;

namespace BilgeHotel.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployePassword { get; set; }
        public string IdentificationNumber { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}
