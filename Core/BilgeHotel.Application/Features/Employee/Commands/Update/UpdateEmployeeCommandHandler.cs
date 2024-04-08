using BilgeHotel.Application.Features.Employee.Commands.Delete;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.Update
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommandRequest, UpdateEmployeeCommandResponse>
    {
        private readonly UserManager<BilgeHotel.Domain.Entities.Identity.Employee> _userManager;
        public UpdateEmployeeCommandHandler(UserManager<Domain.Entities.Identity.Employee> userManager)
        {
            _userManager = userManager;
        }
        public async Task<UpdateEmployeeCommandResponse> Handle(UpdateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            var employeeId = request.Employee.Id.ToString();

            // UserManager kullanarak çalışanı bul
            var employee = await _userManager.FindByIdAsync(employeeId);

            if (employee == null)
            {
                // Çalışan bulunamazsa hata dön
                return new UpdateEmployeeCommandResponse { Message = "Çalışan bulunamadı." };
            }

                employee.IdentificationNumber = request.Employee.IdentificationNumber;
                employee.UserName = request.Employee.UserName;
            employee.Email=request.Employee.Email;
                employee.NormalizedEmail = request.Employee.NormalizedEmail;
            employee.NormalizedUserName = request.Employee.NormalizedUserName;
            employee.PhoneNumber = request.Employee.PhoneNumber;


                var result = await _userManager.UpdateAsync(employee);

                if (result.Succeeded)
            {
                return new UpdateEmployeeCommandResponse { Message = "başarılı" };
            }
            else
            {
                return new UpdateEmployeeCommandResponse { Message= result.Errors.Select(e => e.Description).ToList().ToString() };
            }
        }
    }
}
