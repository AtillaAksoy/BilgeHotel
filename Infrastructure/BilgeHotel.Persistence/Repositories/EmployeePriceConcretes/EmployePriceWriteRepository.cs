using BilgeHotel.Application.Repositories;
using BilgeHotel.Application.Repositories.EmployeePriceRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.EmployeePriceConcretes
{
    public class EmployePriceWriteRepository : WriteRepository<EmployeePrice>, IEmployeePriceWriteRepository
    {
        public EmployePriceWriteRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
