using BilgeHotel.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Domain.Entities
{
    public class Image:BaseEntity
    {
        public string ImagePath { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
