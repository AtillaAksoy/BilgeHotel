using BilgeHotel.Domain.Entities.Identity;
using BilgeHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Dtos
{
    public class EmployePriceDto
    {
        public int? Id { get; set; }
        public Decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }

        public string EmployeeId { get; set; }
        public int PriceTypeId { get; set; }
        public bool IsPassive = false;
        public bool IsDeleted = false;
    }
}
