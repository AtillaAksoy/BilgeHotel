using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList;
using BilgeHotel.Application.Repositories.CustomerRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace BilgeHotel.Persistence.Repositories.CustomerConcretes
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        private readonly BilgeHotelContext _context;

        public CustomerReadRepository(BilgeHotelContext context) : base(context)
        {
            _context = context;
        }

        public async Task<CustomerGetPagedListQueryResponse> GetPagedList(CustomerGetPagedListQueryRequest model)
        {
            var query = _context.Customers.AsQueryable();
            var totalResultsCount = await query.CountAsync();

            var searchBy = model.SearchValue?.ToUpper();
            if (!string.IsNullOrEmpty(searchBy))
            {
                query = query
                    .Where(x => x.FirstName.ToUpper().Contains(searchBy))
                    .Where(x => x.LastName.ToUpper().Contains(searchBy))
                ;
            }

            query = query
                .Where(x => (x.IsDeleted != true))
                .Where(x => (!string.IsNullOrEmpty(model.SearchValue) ? x.FirstName.Contains(model.SearchValue) : true))
                .Where(x => (!string.IsNullOrEmpty(model.SearchValue) ? x.LastName.Contains(model.SearchValue) : true))
                ;

            var filteredResultsCount = await query.CountAsync();
         
               var data = query
                        .Skip(model.Start ?? 0)
                        .Take(model.End?? 50)
                        .ToList();

            //autoMapper yerine Mapster
            var result = data.Adapt<List<CustomerDto>>();

            var response = new CustomerGetPagedListQueryResponse
            {
                TotalCount = totalResultsCount,
                FilteredCount = filteredResultsCount,
                Message = "Success",
                customers = result
            };
            return response;
        }
    }
}
