using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.EmployeePrice.Commands.Create
{
    public class CreateEmployeePriceCommandRequest : IRequest<CreateEmployeePriceCommandResponse>
    {
        public EmployePriceDto EmployePrice { get; set; }
    }
}
