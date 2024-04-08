using Azure.Core;
using BilgeHotel.Application.Features.Employee.Commands.Create;
using BilgeHotel.Application.Features.Employee.Commands.Delete;
using BilgeHotel.Application.Features.Employee.Commands.Update;
using BilgeHotel.Application.Features.Employee.Queries.GetPagedList;
using BilgeHotel.Application.Features.Image.Commands.Create;
using BilgeHotel.Application.Features.Room.Commands.Create;
using BilgeHotel.Application.Features.Room.Commands.Delete;
using BilgeHotel.Application.Features.Room.Commands.Update;
using BilgeHotel.Application.Features.Room.Commands.UpdateRoomByStateForEmployee;
using BilgeHotel.Application.Features.Room.Queries.GetPagedList;
using BilgeHotel.Application.Features.Room.Queries.GetPagedListNonReservationByDate;
using BilgeHotel.Application.Features.Room.Queries.GetPagedListRoomByStateClean;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BilgeHotel.API.Controllers.CustomController
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RoomController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("GetPagedListRoom")]
        public async Task<IActionResult> GetPagedListRoom(RoomGetPagedListQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("GetPagedListRoomByDate")]
        public async Task<IActionResult> GetPagedListRoomByDate(GetPagedListNonReservationByDateQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        /// <summary>
        /// Employee rolu temizlik ise int Id parametresine 3 gönderin (temizlenecek)
        /// Employee rolu elektrikci ise int Id parametresine 4 gönderin (bakım)
        /// durumu dolu olan odaları listelemek için ise 1 gönderin (dolu)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("GetPagedListRoomByStateCleanAndRepair")]
        public async Task<IActionResult> GetPagedListRoomByStateCleanAndRepair(GetPagedListRoomByStateCleanQueryRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("CreateRoom")]
        public async Task<IActionResult> CreateRoom(CreateRoomCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPost("UpdateRoom")]
        public async Task<IActionResult> UpdateRoom(UpdateRoomCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("UpdateRoomByStateForEmployee")]
        public async Task<IActionResult> UpdateRoomByStateForEmployee(UpdateRoomByStateForEmployeeCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpPut("DeleteRoom")]
        public async Task<IActionResult> DeleteRoom(DeleteRoomCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
        [HttpPost("ImageUpload")]
        public async Task<IActionResult> ImageUpload(ImageUploadCommandRequest model)
        {
            return Ok(await _mediator.Send(model));
        }
    }
}
