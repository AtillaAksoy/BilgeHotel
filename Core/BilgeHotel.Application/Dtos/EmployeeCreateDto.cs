using BilgeHotel.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Dtos
{
    public class EmployeeCreateDto
    {

        public Guid? Id { get; set; }
        public string UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string Password { get; set; }
        public string? PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public string IdentificationNumber { get; set; }
    }
}
