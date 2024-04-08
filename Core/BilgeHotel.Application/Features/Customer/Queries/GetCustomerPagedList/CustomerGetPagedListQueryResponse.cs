using BilgeHotel.Application.Dtos;

namespace BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList
{
    public class CustomerGetPagedListQueryResponse : ResponseParameters
    {
        public List<CustomerDto> customers {  get; set; }

    }
}
