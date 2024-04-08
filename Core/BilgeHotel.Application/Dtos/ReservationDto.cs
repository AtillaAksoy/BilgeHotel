using BilgeHotel.Domain.Entities.Identity;
using BilgeHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Dtos
{
    public class ReservationDto
    {
        public int? Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal RealPrice { get; set; }

        public decimal? RefuendedPrice { get; set; }
        public string? CancelDescription { get; set; }
        //Mapping 
        public int ReservationTypeId { get; set; }
        public int ReservationStateId { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public string? EmployeId { get; set; }
    }
}
