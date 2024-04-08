using Mapster;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.Create
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommandRequest, CreateEmployeeCommandResponse>
    {
        private readonly UserManager<BilgeHotel.Domain.Entities.Identity.Employee> _userManager;
        public CreateEmployeeCommandHandler(UserManager<Domain.Entities.Identity.Employee> userManager)
        {
            _userManager = userManager;
        }
        public async Task<CreateEmployeeCommandResponse> Handle(CreateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            
            var user = new Domain.Entities.Identity.Employee { UserName = request.employee.UserName, Email = request.employee.Email , IdentificationNumber = request.employee.IdentificationNumber };

            var result = await _userManager.CreateAsync(user, request.employee.Password);

            if (result.Succeeded)
            {
                return new CreateEmployeeCommandResponse { Message = "Başarılı" };
            }
            else
            {
                return new CreateEmployeeCommandResponse { Message = result.Errors.Select(e => e.Description).ToList().ToString() };
            }
        }
    }
}
