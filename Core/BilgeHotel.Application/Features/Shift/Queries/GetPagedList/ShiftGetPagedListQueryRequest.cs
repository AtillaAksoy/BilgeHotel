using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Queries.GetPagedList
{
    public class ShiftGetPagedListQueryRequest : DtParameters, IRequest<ShiftGetPagedListQueryResponse>
    {
    }
}
