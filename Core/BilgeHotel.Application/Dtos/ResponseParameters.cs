using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Dtos
{
    public class ResponseParameters
    {
        public int? TotalCount { get; set; }
        public int? FilteredCount { get; set; }
        public string? Message { get; set; }
    }
}
