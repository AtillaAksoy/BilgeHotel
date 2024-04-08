using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.Delete
{
    public class DeleteEmployeeCommandRequest:IRequest<DeleteEmployeeCommandResponse>
    {
        public Guid Id { get; set; }
    }
}
