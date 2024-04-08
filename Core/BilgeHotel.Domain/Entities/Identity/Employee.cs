using Microsoft.AspNetCore.Identity;

namespace BilgeHotel.Domain.Entities.Identity
{
    public class Employee : IdentityUser
    {
        public string IdentificationNumber { get; set; }
        public List<EmployeeRole>? Roles { get; set; }

        //vritual eklenecek ve ilişkili verilerin list tipinde ıd leri eklenecek tüm tablolara eklenecek
        public ICollection<Reservation>? Reservations { get; set; }
        public ICollection<EmployeePrice>? EmployeePrices { get; set; }
        public ICollection<Shift>? Shifts { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
