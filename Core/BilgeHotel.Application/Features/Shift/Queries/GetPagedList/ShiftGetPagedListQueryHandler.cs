using BilgeHotel.Application.Features.Shift.Commands.Update;
using BilgeHotel.Application.Repositories.ShiftRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Queries.GetPagedList
{
    public class ShiftGetPagedListQueryHandler : IRequestHandler<ShiftGetPagedListQueryRequest, ShiftGetPagedListQueryResponse>
    {
        private readonly IShiftReadRepository _shiftReadRepository;
        private readonly IMediator _mediator;
        public ShiftGetPagedListQueryHandler(IShiftReadRepository shiftReadRepository, IMediator mediator)
        {
            _shiftReadRepository = shiftReadRepository;
            _mediator = mediator;
        }
        public async Task<ShiftGetPagedListQueryResponse> Handle(ShiftGetPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _shiftReadRepository.GetAllPagedList(request);
            foreach (var item in result.shifts)
            {
                if (item.Date < DateTime.Now.Date)
                {
                    var shift = await _shiftReadRepository.GetByIdAsync(item.Id.Value);
                    if (shift != null)
                    {
                        var send = new UpdateShiftCommandRequest //backgroundservice yerine listeleme ekranına istek geldiğinde tarihi geçmiş shiftleri pasife alma işlemi 
                        {
                            Shift = item
                        };
                        send.Shift.IsPassive = true;
                        var update = await _mediator.Send(send);
                    }
                }
            }
            return result;
        }
    }
}
