using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.EmployeePrice.Commands.Delete
{
    public class EmployePriceDeleteCommandRequest : IRequest<EmployePriceDeleteCommandResponse>
    {
        public int Id { get; set; }
    }
}
