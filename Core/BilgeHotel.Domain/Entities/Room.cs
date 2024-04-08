using BilgeHotel.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Domain.Entities
{
    public class Room:BaseEntity
    {
        public short RoomNumber { get; set; }
        public decimal price { get; set; }
        public bool IsActive { get; set; }
        //public string ImagePath { get; set; }

        //mapping
        public int RoomTypeId { get; set; }
        public  RoomType roomType { get; set; }
        
        public int RoomStateId { get; set; }
        public  RoomState roomState { get; set; }
        
        public virtual ICollection<Reservation>? reservations { get; set; }
        public List<Image>? Images { get; set; }

    }
}
