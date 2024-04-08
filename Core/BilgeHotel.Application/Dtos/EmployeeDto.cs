using BilgeHotel.Domain.Entities;
using BilgeHotel.Domain.Entities.Identity;

namespace BilgeHotel.Application.Dtos
{
    public class EmployeeDto
    {
        public Guid? Id { get; set; }
        public string UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string Email {  get; set; }
        public string? NormalizedEmail { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string Password {  get; set; }
        public string? PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public string IdentificationNumber { get; set; }
        public List<EmployeeRole>? Roles { get; set; }

        public ICollection<ReservationDto>? Reservations { get; set; }
        public ICollection<EmployePriceDto>? EmployeePrices { get; set; }
        public ICollection<ShiftDto>? Shifts { get; set; }

        public decimal? TotalEarnings { get; set; }
    }
}
