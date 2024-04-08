using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Queries.GetPagedList
{
    public class EmployeeGetPagedListQueryResponse : ResponseParameters
    {
      public List<EmployeeDto>? Employees { get; set; }
    }
}
