using BilgeHotel.Application.Features.Customer.Commands.DeleteCustomer;
using BilgeHotel.Application.Features.Customer.Commands.InsertCustomer;
using BilgeHotel.Application.Features.Customer.Commands.UpdateCustomer;
using BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList;
using BilgeHotel.Application.Features.Employee.Commands.Create;
using BilgeHotel.Application.Features.Employee.Commands.Delete;
using BilgeHotel.Application.Features.Employee.Commands.Login;
using BilgeHotel.Application.Features.Employee.Commands.Update;
using BilgeHotel.Application.Features.Employee.Queries.GetPagedList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.API.Controllers.CustomController
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplooyeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmplooyeeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("GetPagedListEmployee")]
        public async Task<IActionResult> GetPagedListEmployee(EmployeeGetPagedListQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginEmployeeCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPost("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(DeleteEmployeeCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
