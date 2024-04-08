using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Customer.Commands.InsertCustomer
{
    public class CreateCustomerCommandResponse : SingleResponseParameters
    {
        public int? Id { get; set; }
    }
}
