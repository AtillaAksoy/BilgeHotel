using BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList;
using BilgeHotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories.CustomerRepositories
{
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
        public Task<CustomerGetPagedListQueryResponse> GetPagedList(CustomerGetPagedListQueryRequest model);
       
    }
}
