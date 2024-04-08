using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Queries.GetPagedListForEarning
{
    public class GetPagedListForEarningQueryResponse : ResponseParameters
    {
        public decimal? TotalEarning { get; set; } 
        public List<ShiftDto>? Shifts { get; set; }
    }
}
