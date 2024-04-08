using BilgeHotel.Application.Repositories.EmployeePriceRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.EmployeePrice.Commands.Create
{
    public class CreateEmployeePriceCommandHandler : IRequestHandler<CreateEmployeePriceCommandRequest, CreateEmployeePriceCommandResponse>
    {
        private readonly IEmployeePriceWriteRepository _employeePriceWriteRepository;
        public CreateEmployeePriceCommandHandler(IEmployeePriceWriteRepository employeePriceWriteRepository)
        {
            _employeePriceWriteRepository = employeePriceWriteRepository;
        }
        public async Task<CreateEmployeePriceCommandResponse> Handle(CreateEmployeePriceCommandRequest request, CancellationToken cancellationToken)
        {
            request.EmployePrice.StartDate = DateTime.Now;
            var data = request.EmployePrice.Adapt<BilgeHotel.Domain.Entities.EmployeePrice>();
            var result = await _employeePriceWriteRepository.AddAsync(data);
            var save = await _employeePriceWriteRepository.SaveAsync();
            if (save==0)
            {
                return new CreateEmployeePriceCommandResponse
                {
                    Message = "kaydederken hata"
                };
            }
            if (result)
            {
                return new CreateEmployeePriceCommandResponse
                {
                    Message = "başarılı işlem"
                };
            }
            else
            {
                return new CreateEmployeePriceCommandResponse
                {
                    Message = "hata"
                };
            }
        }
    }
}
