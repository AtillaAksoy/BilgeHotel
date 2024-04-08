using BilgeHotel.Application.Features.Room.Commands.Create;
using BilgeHotel.Application.Features.Room.Commands.Delete;
using BilgeHotel.Application.Features.Room.Commands.Update;
using BilgeHotel.Application.Features.Room.Queries.GetPagedList;
using BilgeHotel.Application.Features.Shift.Commands.Create;
using BilgeHotel.Application.Features.Shift.Commands.Delete;
using BilgeHotel.Application.Features.Shift.Commands.Update;
using BilgeHotel.Application.Features.Shift.Queries.GetPagedList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.API.Controllers.CustomController
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes ="Admin")]
    public class ShiftController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ShiftController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("GetPagedListShift")]
        public async Task<IActionResult> GetPagedListShift(ShiftGetPagedListQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("CreateShift")]
        public async Task<IActionResult> CreateShift(CreateShiftCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPost("UpdateShift")]
        public async Task<IActionResult> UpdateShift(UpdateShiftCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("DeleteShift")]
        public async Task<IActionResult> DeleteShift(DeleteShiftCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
