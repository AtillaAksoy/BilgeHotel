using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.EmployeePrice.Commands.Update
{
    public class EmployePriceUpdateCommandRequest : IRequest<EmployePriceUpdateCommandResponse>
    {
        public EmployePriceDto employePrice { get; set; }
    }
}
