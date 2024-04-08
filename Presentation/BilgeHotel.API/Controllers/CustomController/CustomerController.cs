using BilgeHotel.Application.Features.Customer.Commands.DeleteCustomer;
using BilgeHotel.Application.Features.Customer.Commands.InsertCustomer;
using BilgeHotel.Application.Features.Customer.Commands.UpdateCustomer;
using BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.API.Controllers.CustomController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost("GetPagedListCustomer")]
        public async Task<IActionResult> GetPagedListCustomer(CustomerGetPagedListQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(DeleteCustomerCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
