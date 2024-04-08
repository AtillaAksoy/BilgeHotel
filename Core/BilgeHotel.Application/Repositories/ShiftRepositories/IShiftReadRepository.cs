using BilgeHotel.Application.Features.Shift.Queries.GetPagedList;
using BilgeHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories.ShiftRepositories
{
    public interface IShiftReadRepository : IReadRepository<Shift>
    {
        Task<ShiftGetPagedListQueryResponse> GetAllPagedList(ShiftGetPagedListQueryRequest request);
    }
}
