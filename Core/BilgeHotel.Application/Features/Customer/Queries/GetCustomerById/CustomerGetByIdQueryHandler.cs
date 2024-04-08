using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList;
using BilgeHotel.Application.Repositories.CustomerRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BilgeHotel.Application.Features.Customer.Queries.GetCustomerById
{
    public class CustomerGetByIdQueryHandler : IRequestHandler<CustomerGetByIdQueryRequest, CustomerGetByIdQueryResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public CustomerGetByIdQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<CustomerGetByIdQueryResponse> Handle(CustomerGetByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new CustomerGetByIdQueryResponse();
            try
            {
                var result = await _customerReadRepository.GetByIdAsync(request.Id);
                if (result == null)
                {
                    response.Message = "Müşteri bulunamadı.";
                    return response;
                }
                //map
                var data = result.Adapt<CustomerDto>();
                response.Message = "Başarılı";
                response.Customer = data;
                return response;
            }
            catch (Exception ex)
            {
                response.Message = $"hata{ex.Message}";
                return response;
            }
            
        }
    }
}
