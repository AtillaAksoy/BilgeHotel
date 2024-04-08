using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.UpdateEmployeRole
{
    public class UpdateEmployeeRoleCommandRequest : IRequest<UpdateEmployeeRoleCommandResponse>
    {
        public string EmployeeId { get; set; }
        public string RoleId { get; set; }
    }
}
