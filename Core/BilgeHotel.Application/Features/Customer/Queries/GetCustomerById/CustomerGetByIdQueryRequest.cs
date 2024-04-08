using BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Customer.Queries.GetCustomerById
{
    public class CustomerGetByIdQueryRequest : IRequest<CustomerGetByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
