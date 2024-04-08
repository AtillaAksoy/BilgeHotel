using BilgeHotel.Application.Repositories.CustomerRepositories;
using MediatR;

namespace BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList
{
    public class CustomerGetPagedListQueryHandler : IRequestHandler<CustomerGetPagedListQueryRequest, CustomerGetPagedListQueryResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public CustomerGetPagedListQueryHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }
        public async Task<CustomerGetPagedListQueryResponse> Handle(CustomerGetPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _customerReadRepository.GetPagedList(request);
            return result;  
        }
    }
}
