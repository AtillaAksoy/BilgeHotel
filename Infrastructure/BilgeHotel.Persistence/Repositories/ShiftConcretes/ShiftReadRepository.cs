using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Features.Room.Queries.GetPagedList;
using BilgeHotel.Application.Features.Shift.Queries.GetPagedList;
using BilgeHotel.Application.Repositories.ShiftRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.ShiftConcretes
{
    public class ShiftReadRepository : ReadRepository<Shift>, IShiftReadRepository
    {
        private readonly BilgeHotelContext _context;
        public ShiftReadRepository(BilgeHotelContext context) : base(context)
        {
            _context = context;
        }
        public async Task<ShiftGetPagedListQueryResponse> GetAllPagedList(ShiftGetPagedListQueryRequest request)
        {
            var query = _context.Shifts.AsQueryable().Include(x => x.Employee).Include(x => x.workType).Include(x => x.shiftState).Where(x => x.IsPassive != true && x.IsDeleted != true);
            var totalResultsCount = await query.CountAsync();

            var searchBy = request.SearchValue?.ToUpper();
            if (!string.IsNullOrEmpty(searchBy))
            {
                query = query
                     .Where(x => x.Employee.UserName.ToUpper().Contains(searchBy))
                     .Where(x => x.Employee.Email.ToUpper().Contains(searchBy))
                    .Where(x => x.workType.Name.ToUpper().Contains(searchBy))
                    .Where(x => x.workType.Description.ToUpper().Contains(searchBy))
                ;
            }



            query = query
    .Where(x => (x.IsDeleted != true && x.IsPassive != true))
    .Where(x =>
        (string.IsNullOrEmpty(request.SearchValue) ||
        (x.workType != null && (x.workType.Name.Contains(request.SearchValue) || x.workType.Description.Contains(request.SearchValue) || (x.Employee != null && (x.Employee.UserName.Contains(request.SearchValue) || x.Employee.Email.Contains(request.SearchValue)))))));

            var filteredResultsCount = await query.CountAsync();

            var data = query
                     .Skip(request.Start ?? 0)
                     .Take(request.End ?? 50)
                     .ToList();


            var result = data.Adapt<List<ShiftDto>>();

            var response = new ShiftGetPagedListQueryResponse
            {
                TotalCount = totalResultsCount,
                FilteredCount = filteredResultsCount,
                Message = "Success",
                shifts= result
            };

            return response;
        }

        public async Task<ShiftGetPagedListQueryResponse> GetAllPagedListByEarning(ShiftGetPagedListQueryRequest request)
        {
            var query = _context.Shifts.AsQueryable().Include(x => x.Employee).Include(x => x.workType).Include(x => x.shiftState).Where(x => x.IsPassive == true && x.IsDeleted != true);
            var totalResultsCount = await query.CountAsync();

            var searchBy = request.SearchValue?.ToUpper();
            if (!string.IsNullOrEmpty(searchBy))
            {
                query = query
                     .Where(x => x.Employee.UserName.ToUpper().Contains(searchBy))
                     .Where(x => x.Employee.Email.ToUpper().Contains(searchBy))
                    .Where(x => x.workType.Name.ToUpper().Contains(searchBy))
                    .Where(x => x.workType.Description.ToUpper().Contains(searchBy))
                ;
            }



            query = query
    .Where(x => (x.IsDeleted != true && x.IsPassive != true))
    .Where(x =>
        (string.IsNullOrEmpty(request.SearchValue) ||
        (x.workType != null && (x.workType.Name.Contains(request.SearchValue) || x.workType.Description.Contains(request.SearchValue) || (x.Employee != null && (x.Employee.UserName.Contains(request.SearchValue) || x.Employee.Email.Contains(request.SearchValue)))))));

            var filteredResultsCount = await query.CountAsync();

            var data = query
                     .Skip(request.Start ?? 0)
                     .Take(request.End ?? 50)
                     .ToList();


            var result = data.Adapt<List<ShiftDto>>();


            var response = new ShiftGetPagedListQueryResponse
            {
                TotalCount = totalResultsCount,
                FilteredCount = filteredResultsCount,
                Message = "Success",
                shifts = result
            };

            return response;
        }
    }
}
