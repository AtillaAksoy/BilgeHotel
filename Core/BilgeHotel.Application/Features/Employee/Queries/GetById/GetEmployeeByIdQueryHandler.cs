using BilgeHotel.Application.Dtos;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Queries.GetById
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQueryRequest, GetEmployeeByIdQueryResponse>
    {
        private readonly UserManager<BilgeHotel.Domain.Entities.Identity.Employee> _userManager;
        public GetEmployeeByIdQueryHandler(UserManager<Domain.Entities.Identity.Employee> userManager)
        {
            _userManager = userManager;
        }
        public async Task<GetEmployeeByIdQueryResponse> Handle(GetEmployeeByIdQueryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var employee = await _userManager.FindByIdAsync(request.Id.ToString());

                if (employee == null)
                {
                    return new GetEmployeeByIdQueryResponse { Message = "Kullanıcı bulunamadı." };
                }

                var employeeDto = employee.Adapt<EmployeeDto>();

                return new GetEmployeeByIdQueryResponse { Employee = employeeDto };
            }
            catch (Exception ex)
            {
                return new GetEmployeeByIdQueryResponse { Message = ex.Message };
            }
        }
    }
}
