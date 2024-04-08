using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.UpdateEmployeRole
{
    public class UpdateEmployeeRoleCommandHandler : IRequestHandler<UpdateEmployeeRoleCommandRequest, UpdateEmployeeRoleCommandResponse>
    {
        private readonly UserManager<BilgeHotel.Domain.Entities.Identity.Employee> _userManager;
        public UpdateEmployeeRoleCommandHandler(UserManager<Domain.Entities.Identity.Employee> userManager)
        {
            _userManager = userManager;
        }
        public async Task<UpdateEmployeeRoleCommandResponse> Handle(UpdateEmployeeRoleCommandRequest request, CancellationToken cancellationToken)
        {
            var employee = await _userManager.FindByIdAsync(request.EmployeeId);

            if (employee == null)
            {
                // Employee not found
                return new UpdateEmployeeRoleCommandResponse {Message = "Employee bulunamdı." };
            }

            // Role update
            var roles = await _userManager.GetRolesAsync(employee);
            var currentRoleId = roles.FirstOrDefault();

            if (currentRoleId != null)
            {
                // Remove current role
                await _userManager.RemoveFromRoleAsync(employee, currentRoleId);
            }

            // Assign new role
            await _userManager.AddToRoleAsync(employee, request.RoleId);

            return new UpdateEmployeeRoleCommandResponse { Message = "başarılı" };
        }
    }
}
