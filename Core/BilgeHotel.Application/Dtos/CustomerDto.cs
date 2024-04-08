﻿namespace BilgeHotel.Application.Dtos
{
    public class CustomerDto 
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployePassword { get; set; }
        public string IdentificationNumber { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
