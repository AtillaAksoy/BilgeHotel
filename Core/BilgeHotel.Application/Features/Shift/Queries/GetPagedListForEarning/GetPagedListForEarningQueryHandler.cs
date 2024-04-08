using BilgeHotel.Application.Repositories.ShiftRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Queries.GetPagedListForEarning
{
    public class GetPagedListForEarningQueryHandler : IRequestHandler<GetPagedListForEarningQueryRequest, GetPagedListForEarningQueryResponse>
    {
        private readonly IShiftReadRepository _shiftReadRepository;
        private readonly IMediator _mediator;
        public GetPagedListForEarningQueryHandler(IShiftReadRepository shiftReadRepository, IMediator mediator)
        {
            _shiftReadRepository = shiftReadRepository;
            _mediator = mediator;
        }
        public Task<GetPagedListForEarningQueryResponse> Handle(GetPagedListForEarningQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
