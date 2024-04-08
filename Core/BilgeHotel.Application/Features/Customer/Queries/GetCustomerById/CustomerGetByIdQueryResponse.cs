using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Customer.Queries.GetCustomerById
{
    public class CustomerGetByIdQueryResponse : SingleResponseParameters
    {
        public CustomerDto? Customer {  get; set; }
    }
}
