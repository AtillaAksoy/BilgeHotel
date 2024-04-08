using BilgeHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Dtos
{
    public class RoomDto
    {
        public int? Id { get; set; }
        public short RoomNumber { get; set; }
        public decimal price { get; set; }
        public bool IsActive { get; set; }
        //public string ImagePath { get; set; }

        //mapping
        public int RoomTypeId { get; set; }

        public int RoomStateId { get; set; }

        public List<ReservationDto>? reservations { get; set; }
        public List<Image>? Images { get; set; }
    }
}
