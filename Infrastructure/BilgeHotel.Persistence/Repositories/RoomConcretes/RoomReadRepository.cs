using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Features.Reservation.Queries.GetPagedList;
using BilgeHotel.Application.Features.Room.Queries.GetPagedList;
using BilgeHotel.Application.Features.Room.Queries.GetPagedListNonReservationByDate;
using BilgeHotel.Application.Features.Room.Queries.GetPagedListRoomByStateClean;
using BilgeHotel.Application.Repositories.RoomRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.RoomConcretes
{
    public class RoomReadRepository : ReadRepository<Room>, IRoomReadRepository
    {
        private readonly BilgeHotelContext _context;
        public RoomReadRepository(BilgeHotelContext context) : base(context)
        {
            _context = context;
        }
        public async Task<RoomGetPagedListQueryResponse> GetAllPagedList(RoomGetPagedListQueryRequest request)
        {
            var query = _context.Rooms.AsQueryable().Include(x => x.roomState).Include(x => x.reservations).Include(x => x.roomType).Include(x => x.Images).Where(x => x.IsPassive != true && x.IsDeleted != true);
            var totalResultsCount = await query.CountAsync();

            var searchBy = request.SearchValue?.ToUpper();
            if (!string.IsNullOrEmpty(searchBy))
            {
                query = query
                     .Where(x => x.roomType.Name.ToUpper().Contains(searchBy))
                      .Where(x => x.RoomNumber.ToString().Contains(searchBy))
                    .Where(x => x.roomState.State.ToUpper().Contains(searchBy))
                    .Where(x => x.roomState.Note.ToUpper().Contains(searchBy))
                ;
            }



            query = query
    .Where(x => (x.IsDeleted != true && x.IsPassive != true))
    .Where(x =>
        (string.IsNullOrEmpty(request.SearchValue) ||
        (x.roomType != null && (x.roomType.Name.Contains(request.SearchValue) ||
                                (x.roomState != null && (x.roomState.State.Contains(request.SearchValue) ||
                                                         x.roomState.Note.Contains(request.SearchValue)) ||
                                (x.RoomNumber.ToString().Contains(request.SearchValue))))
        )
    ));

            var filteredResultsCount = await query.CountAsync();

            var data = query
                     .Skip(request.Start ?? 0)
                     .Take(request.End ?? 50)
                     .ToList();


            var result = data.Adapt<List<RoomDto>>();

            var response = new RoomGetPagedListQueryResponse
            {
                TotalCount = totalResultsCount,
                FilteredCount = filteredResultsCount,
                Message = "Success",
                rooms = result
            };

            return response;
        }
        public async Task<GetPagedListNonReservationByDateQueryResponse> GetAllPagedListByDate(GetPagedListNonReservationByDateQueryRequest request)
        {
            DateTime startDate = request.StartDate;
            DateTime endDate = request.EndDate;

            var reservedRoomIds = await _context.Reservations
                  .Where(r => (startDate.Date <= r.EndDate.Date && endDate.Date >= r.StartDate.Date) || (startDate.Date >= r.StartDate.Date && endDate.Date <= r.EndDate.Date))
                .Select(r => r.RoomId)
                .ToListAsync();

            var query = _context.Rooms
                .Include(x => x.roomState)
                .Include(x => x.reservations)
                .Include(x => x.roomType)
                .Include(x => x.Images)
                .Where(x => x.IsPassive != true && x.IsDeleted != true && !reservedRoomIds.Contains(x.Id));

            #region Old
            //        var query = _context.Rooms
            //.Include(x => x.roomState)
            //.Include(x => x.reservations)
            //.Include(x => x.roomType)
            //.Include(x => x.Images)
            //.Where(x => x.IsPassive != true && x.IsDeleted != true)
            //.Where(x => !x.reservations.Any(r => r.StartDate < endDate && r.EndDate > startDate)); 
            #endregion

            var totalResultsCount = await query.CountAsync();
            var searchBy = request.SearchValue?.ToUpper();
            if (!string.IsNullOrEmpty(searchBy))
            {
                query = query
                     .Where(x => x.roomType.Name.ToUpper().Contains(searchBy))
                      .Where(x => x.RoomNumber.ToString().Contains(searchBy))
                    .Where(x => x.roomState.State.ToUpper().Contains(searchBy))
                    .Where(x => x.roomState.Note.ToUpper().Contains(searchBy))
                ;
            }



            query = query
    .Where(x => (x.IsDeleted != true && x.IsPassive != true))
    .Where(x =>
        (string.IsNullOrEmpty(request.SearchValue) ||
        (x.roomType != null && (x.roomType.Name.Contains(request.SearchValue) ||
                                (x.roomState != null && (x.roomState.State.Contains(request.SearchValue) ||
                                                         x.roomState.Note.Contains(request.SearchValue)) ||
                                (x.RoomNumber.ToString().Contains(request.SearchValue))))
        )
    ));

            var filteredResultsCount = await query.CountAsync();

            var data = query
                     .Skip(request.Start ?? 0)
                     .Take(request.End ?? 50)
                     .ToList();
            foreach (var room in data)
            {
                // Oda fiyatını hesapla (günlük fiyat * gün sayısı)
                var totalPrice = room.price * (decimal)(endDate.Date - startDate.Date).TotalDays;

                // Oda nesnesine fiyatı ata
                room.price = totalPrice;
            }

            var result = data.Adapt<List<RoomDto>>();

            var response = new GetPagedListNonReservationByDateQueryResponse
            {
                TotalCount = totalResultsCount,
                FilteredCount = filteredResultsCount,
                Message = "Success",
                rooms = result
            };

            return response;
        }
        public async Task<GetPagedListRoomByStateCleanQueryResponse> GetAllPagedListByState(GetPagedListRoomByStateCleanQueryRequest request)
        {
            var query = _context.Rooms.AsQueryable().Include(x => x.roomState).Include(x => x.reservations).ThenInclude(x=>x.customer).Include(x => x.roomType).Include(x => x.Images).Where(x => x.IsPassive != true && x.IsDeleted != true && x.roomState.Id == request.Id);
            var totalResultsCount = await query.CountAsync();

            var searchBy = request.SearchValue?.ToUpper();
            if (!string.IsNullOrEmpty(searchBy))
            {
                query = query
                     .Where(x => x.roomType.Name.ToUpper().Contains(searchBy))
                      .Where(x => x.RoomNumber.ToString().Contains(searchBy))
                    .Where(x => x.roomState.State.ToUpper().Contains(searchBy))
                    .Where(x => x.roomState.Note.ToUpper().Contains(searchBy))
                ;
            }



            query = query
    .Where(x => (x.IsDeleted != true && x.IsPassive != true))
    .Where(x =>
        (string.IsNullOrEmpty(request.SearchValue) ||
        (x.roomType != null && (x.roomType.Name.Contains(request.SearchValue) ||
                                (x.roomState != null && (x.roomState.State.Contains(request.SearchValue) ||
                                                         x.roomState.Note.Contains(request.SearchValue)) ||
                                (x.RoomNumber.ToString().Contains(request.SearchValue))))
        )
    ));

            var filteredResultsCount = await query.CountAsync();

            var data = query
                     .Skip(request.Start ?? 0)
                     .Take(request.End ?? 50)
                     .ToList();


            var result = data.Adapt<List<RoomDto>>();

            var response = new GetPagedListRoomByStateCleanQueryResponse
            {
                TotalCount = totalResultsCount,
                FilteredCount = filteredResultsCount,
                Message = "Success",
                rooms = result
            };

            return response;
        }
    }
}
