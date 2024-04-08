using BilgeHotel.Domain.Entities.Identity;
using BilgeHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Dtos
{
    public class ShiftDto
    {
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? RealStartDate { get; set; }
        public DateTime? RealEndDate { get; set; }
        public string? ExcuseDescription { get; set; }
        public string EmployeeId { get; set; }
        public int WorkTypeId { get; set; }
        public int ShiftStateId { get; set; }
        public bool? IsPassive { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? TotalCost { get; set; }
    }
}
