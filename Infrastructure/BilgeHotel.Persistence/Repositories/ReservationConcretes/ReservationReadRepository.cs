using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Features.Customer.Queries.GetCustomerPagedList;
using BilgeHotel.Application.Features.Reservation.Queries.GetPagedList;
using BilgeHotel.Application.Features.Reservation.Queries.GetPagedListByCloseToEnd;
using BilgeHotel.Application.Repositories.ReservationRepositories;
using BilgeHotel.Application.Repositories.ReservationStateRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.ReservationConcretes
{
    public class ReservationReadRepository : ReadRepository<Reservation>, IReservationReadRepository
    {
        private readonly BilgeHotelContext _context;
        public ReservationReadRepository(BilgeHotelContext context) : base(context)
        {
            _context = context;
        }

        //IQueryable<Reservation> yerine IEnumerable<Reservation>
        public async Task<ReservationGetPagedListQueryResponse> GetAllPagedList(ReservationGetPagedListQueryRequest request)
        {
            var query = _context.Reservations.AsQueryable().Include(x=>x.customer).Include(x=>x.employee).Include(x=>x.room).Include(x=>x.reservationState).Include(x => x.reservationType).Where(x=>x.IsPassive!=true&&x.IsDeleted!=true);
            var totalResultsCount = await query.CountAsync();

            var searchBy = request.SearchValue?.ToUpper();
            if (!string.IsNullOrEmpty(searchBy))
            {
                query = query
                    .Where(x => x.customer.FirstName.ToUpper().Contains(searchBy))
                    .Where(x => x.customer.LastName.ToUpper().Contains(searchBy))
                    .Where(x => x.customer.Email.ToUpper().Contains(searchBy))
                    .Where(x => x.employee.UserName.ToUpper().Contains(searchBy))
                    .Where(x => x.employee.Email.ToUpper().Contains(searchBy))
                ;
            }

            #region old
            //query = query
            //    .Where(x => (x.IsDeleted != true&&x.IsPassive != true))
            //    .Where(x => (!string.IsNullOrEmpty(dtParameters.SearchValue) ? x.customer.FirstName.Contains(dtParameters.SearchValue) : true))
            //    .Where(x => (!string.IsNullOrEmpty(dtParameters.SearchValue) ? x.customer.LastName.Contains(dtParameters.SearchValue) : true))
            //     .Where(x => (!string.IsNullOrEmpty(dtParameters.SearchValue) ? x.employee.UserName.Contains(dtParameters.SearchValue) : true))
            //      .Where(x => (!string.IsNullOrEmpty(dtParameters.SearchValue) ? x.customer.Email.Contains(dtParameters.SearchValue) : true))
            //       .Where(x => (!string.IsNullOrEmpty(dtParameters.SearchValue) ? x.employee.Email.Contains(dtParameters.SearchValue) : true))
            //    ; 
            #endregion

            query = query
            .Where(x => (x.IsDeleted != true && x.IsPassive != true))
            .Where(x =>
            (string.IsNullOrEmpty(request.SearchValue) ||
            (x.customer != null && (x.customer.FirstName.Contains(request.SearchValue) ||
                                 x.customer.LastName.Contains(request.SearchValue) ||
                                 x.customer.Email.Contains(request.SearchValue))) ||
            (x.employee != null && (x.employee.UserName.Contains(request.SearchValue) ||
                                 x.employee.Email.Contains(request.SearchValue))))
            );

            var filteredResultsCount = await query.CountAsync();

            var data =  query
                     .Skip(request.Start ?? 0 )
                     .Take(request.End ?? 50)
                     .ToList();


            var result =  data.Adapt<List<ReservationDto>>();

            var response = new ReservationGetPagedListQueryResponse
            {
                TotalCount = totalResultsCount,
                FilteredCount = filteredResultsCount,
                Message = "Success",
                Reservations = result
            };

            return response;
        }



        public async Task<GetPagedListByCloseToEndQueryResponse> GetAllPagedListByCloseToEnd(GetPagedListByCloseToEndQueryRequest request)
        {
            #region Old
            //var now = DateTime.Now;
            //var oneHourBeforeEnd = now.AddHours(1); // 1 saat sonra

            //var query = _context.Reservations
            //    .AsQueryable()
            //    .Include(x => x.customer)
            //    .Include(x => x.employee)
            //    .Include(x => x.room)
            //    .Include(x => x.reservationState)
            //    .Include(x => x.reservationType)
            //    .Where(x => x.IsPassive != true && x.IsDeleted != true &&
            //                (x.EndDate - now).TotalHours <= 1).AsQueryable(); // 1 saatten az kalanlar 
            #endregion

            var now = DateTime.Now;
            var query = _context.Reservations //ChatGpt Sorgusu
                .AsQueryable()
                .Include(x => x.customer)
                .Include(x => x.employee)
                .Include(x => x.room)
                .Include(x => x.reservationState)
                .Include(x => x.reservationType)
                .Where(x => x.IsPassive != true && x.IsDeleted != true &&
                            EF.Functions.DateDiffHour(now, x.EndDate) <= 1); // 1 saatten az kalanlar

            var totalResultsCount = await query.CountAsync();

            var searchBy = request.SearchValue?.ToUpper();
            if (!string.IsNullOrEmpty(searchBy))
            {
                query = query
                    .Where(x => x.customer.FirstName.ToUpper().Contains(searchBy))
                    .Where(x => x.customer.LastName.ToUpper().Contains(searchBy))
                    .Where(x => x.customer.Email.ToUpper().Contains(searchBy))
                    .Where(x => x.employee.UserName.ToUpper().Contains(searchBy))
                    .Where(x => x.employee.Email.ToUpper().Contains(searchBy))
                ;
            }

            query = query
            .Where(x => (x.IsDeleted != true && x.IsPassive != true))
            .Where(x =>
            (string.IsNullOrEmpty(request.SearchValue) ||
            (x.customer != null && (x.customer.FirstName.Contains(request.SearchValue) ||
                                 x.customer.LastName.Contains(request.SearchValue) ||
                                 x.customer.Email.Contains(request.SearchValue))) ||
            (x.employee != null && (x.employee.UserName.Contains(request.SearchValue) ||
                                 x.employee.Email.Contains(request.SearchValue))))
            );

            var filteredResultsCount = await query.CountAsync();

            var data = query
                     .Skip(request.Start ?? 0)
                     .Take(request.End ?? 50)
                     .ToList();


            var result = data.Adapt<List<ReservationDto>>();

            var response = new GetPagedListByCloseToEndQueryResponse
            {
                TotalCount = totalResultsCount,
                FilteredCount = filteredResultsCount,
                Message = "Success",
                Reservations = result
            };

            return response;
        }
    }
}
