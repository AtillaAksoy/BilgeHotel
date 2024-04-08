using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.Delete
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommandRequest, DeleteEmployeeCommandResponse>
    {
        private readonly UserManager<BilgeHotel.Domain.Entities.Identity.Employee> _userManager;

        public DeleteEmployeeCommandHandler(UserManager<BilgeHotel.Domain.Entities.Identity.Employee> userManager)
        {
            _userManager = userManager;
        }
        public async Task<DeleteEmployeeCommandResponse> Handle(DeleteEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            // Silinecek çalışanın ID'sini al
            var employeeId = request.Id.ToString();

            // UserManager kullanarak çalışanı bul
            var employee = await _userManager.FindByIdAsync(employeeId);

            if (employee == null)
            {
                // Çalışan bulunamazsa hata dön
                return new DeleteEmployeeCommandResponse { Message = "Çalışan bulunamadı." };
            }

            try
            {
                employee.IsDeleted = true;

                var result = await _userManager.UpdateAsync(employee);

                if (result.Succeeded)
                {
                    return new DeleteEmployeeCommandResponse { Message = "başarılı" };
                }
                else
                {
                    return new DeleteEmployeeCommandResponse { Message = result.Errors.Select(e => e.Description).ToList().ToString() };
                }
            }
            catch (Exception ex)
            {
                // Bir hata oluşursa hatayı dön
                return new DeleteEmployeeCommandResponse { Message = ex.Message };
            }
        }
    }
}
