using BilgeHotel.Application.Features.Employee.Commands.Create;
using BilgeHotel.Application.Features.Employee.Commands.Delete;
using BilgeHotel.Application.Features.Employee.Commands.Update;
using BilgeHotel.Application.Features.Employee.Queries.GetPagedList;
using BilgeHotel.Application.Features.EmployeePrice.Commands.Create;
using BilgeHotel.Application.Features.EmployeePrice.Commands.Delete;
using BilgeHotel.Application.Features.EmployeePrice.Commands.Update;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.API.Controllers.CustomController
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePriceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeePriceController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("CreateEmployeePrice")]
        public async Task<IActionResult> CreateEmployeePrice(CreateEmployeePriceCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPost("UpdateEmployeePrice")]
        public async Task<IActionResult> UpdateEmployeePrice(EmployePriceUpdateCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("DeleteEmployeePrice")]
        public async Task<IActionResult> DeleteEmployeePrice(EmployePriceDeleteCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
