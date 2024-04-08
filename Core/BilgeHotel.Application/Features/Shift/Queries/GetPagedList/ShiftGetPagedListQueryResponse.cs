using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Queries.GetPagedList
{
    public class ShiftGetPagedListQueryResponse : ResponseParameters
    {
        public List<ShiftDto> shifts {  get; set; }
    }
}
