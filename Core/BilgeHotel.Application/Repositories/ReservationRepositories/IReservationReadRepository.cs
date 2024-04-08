using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Features.Reservation.Queries.GetPagedList;
using BilgeHotel.Application.Features.Reservation.Queries.GetPagedListByCloseToEnd;
using BilgeHotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories.ReservationRepositories
{
    public interface IReservationReadRepository : IReadRepository<Reservation>
    {
        Task<ReservationGetPagedListQueryResponse> GetAllPagedList(ReservationGetPagedListQueryRequest request);
        Task<GetPagedListByCloseToEndQueryResponse> GetAllPagedListByCloseToEnd(GetPagedListByCloseToEndQueryRequest request);
    }
}
