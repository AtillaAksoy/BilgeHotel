using BilgeHotel.Application.Features.Employee.Commands.Create;
using BilgeHotel.Application.Features.Employee.Commands.Delete;
using BilgeHotel.Application.Features.Employee.Commands.Update;
using BilgeHotel.Application.Features.Employee.Queries.GetPagedList;
using BilgeHotel.Application.Features.Reservation.Commands.Create;
using BilgeHotel.Application.Features.Reservation.Commands.Delete;
using BilgeHotel.Application.Features.Reservation.Commands.Update;
using BilgeHotel.Application.Features.Reservation.Commands.UpdateReservationByStateForReceptionist;
using BilgeHotel.Application.Features.Reservation.Queries.GetPagedList;
using BilgeHotel.Application.Features.Reservation.Queries.GetPagedListByCloseToEnd;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.API.Controllers.CustomController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("GetPagedListReservation")]
        public async Task<IActionResult> GetPagedListReservation(ReservationGetPagedListQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("GetPagedListByCloseToEnd")]
        public async Task<IActionResult> GetPagedListByCloseToEnd(GetPagedListByCloseToEndQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("CreateReservation")]
        public async Task<IActionResult> CreateReservation(CreateReservationCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPost("UpdateReservation")]
        public async Task<IActionResult> UpdateReservation(UpdateReservationCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("UpdateReservationByStateForReceptionist")]
        public async Task<IActionResult> UpdateReservationByStateForReceptionist(UpdateReservationByStateCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPut("DeleteReservation")]
        public async Task<IActionResult> DeleteReservation(DeleteReservationCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
