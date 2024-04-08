using BilgeHotel.Application.Features.EmployeePrice.Commands.Create;
using BilgeHotel.Application.Repositories.EmployeePriceRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.EmployeePrice.Commands.Delete
{
    public class EmployePriceDeleteCommandHandler : IRequestHandler<EmployePriceDeleteCommandRequest, EmployePriceDeleteCommandResponse>
    {
        private readonly IEmployeePriceReadRepository _employeePriceReadRepository;
        private readonly IEmployeePriceWriteRepository _employeePriceWriteRepository;
        public EmployePriceDeleteCommandHandler(IEmployeePriceReadRepository employeePriceReadRepository, IEmployeePriceWriteRepository employeePriceWriteRepository)
        {
            _employeePriceReadRepository = employeePriceReadRepository;
            _employeePriceWriteRepository = employeePriceWriteRepository;
        }
        public async Task<EmployePriceDeleteCommandResponse> Handle(EmployePriceDeleteCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _employeePriceReadRepository.GetByIdAsync(request.Id);
            if (entity == null) { return new EmployePriceDeleteCommandResponse { Message = "bulunamadı" }; }
            entity.IsActive = false;
            entity.IsDeleted = true;
            entity.IsPassive = true;
            var update = await _employeePriceWriteRepository.Update(entity);
            var save = await _employeePriceWriteRepository.SaveAsync();
            if (save == 0)
            {
                return new EmployePriceDeleteCommandResponse
                {
                    Message = "kaydederken hata"
                };
            }
            if (update)
            {
                return new EmployePriceDeleteCommandResponse { Message = "başarılı" };
            }
            else
            {
                return new EmployePriceDeleteCommandResponse { Message = "hata" };
            }
        }
    }
}
