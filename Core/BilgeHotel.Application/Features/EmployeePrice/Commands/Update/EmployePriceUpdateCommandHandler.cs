using BilgeHotel.Application.Features.EmployeePrice.Commands.Delete;
using BilgeHotel.Application.Repositories.EmployeePriceRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.EmployeePrice.Commands.Update
{
    public class EmployePriceUpdateCommandHandler : IRequestHandler<EmployePriceUpdateCommandRequest, EmployePriceUpdateCommandResponse>
    {
        private readonly IMediator _mediator;
        private readonly IEmployeePriceReadRepository _employeePriceReadRepository;
        private readonly IEmployeePriceWriteRepository _employeePriceWriteRepository;
        public EmployePriceUpdateCommandHandler(IMediator mediator, IEmployeePriceReadRepository employeePriceReadRepository, IEmployeePriceWriteRepository employeePriceWriteRepository)
        {
            _mediator = mediator;
            _employeePriceReadRepository = employeePriceReadRepository;
            _employeePriceWriteRepository = employeePriceWriteRepository;
        }
        public async Task<EmployePriceUpdateCommandResponse> Handle(EmployePriceUpdateCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.employePrice.Id == null)
            {
                return new EmployePriceUpdateCommandResponse { Message = "Id boş" };
            }
            var delete = new EmployePriceDeleteCommandRequest { Id = request.employePrice.Id.Value};
            var result = await _mediator.Send(delete);
            if (result.Message== "başarılı")
            {
                var emoloyeprice = new Domain.Entities.EmployeePrice
                {
                    IsActive = true,
                    StartDate = request.employePrice.StartDate,
                    EndDate = request.employePrice.EndDate,
                    EmployeeId = request.employePrice.EmployeeId,
                    PriceTypeId = request.employePrice.PriceTypeId,
                    Price = request.employePrice.Price
                };
                var added = await _employeePriceWriteRepository.AddAsync(emoloyeprice);
                var save = await _employeePriceWriteRepository.SaveAsync();
                if (save == 0)
                {
                    return new EmployePriceUpdateCommandResponse
                    {
                        Message = "kaydederken hata"
                    };
                }
                if (added)
                {
                    return new EmployePriceUpdateCommandResponse { Message = "başarılı" };
                }
            }
           
            return new EmployePriceUpdateCommandResponse { Message = "hata" };
        }
    }
}
