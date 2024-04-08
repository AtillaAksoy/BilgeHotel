using BilgeHotel.Application.Repositories;
using BilgeHotel.Domain.Entities.Common;
using BilgeHotel.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BilgeHotel.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity //class
    {
        private readonly BilgeHotelContext _context;

        public ReadRepository(BilgeHotelContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public async Task<T> GetByIdAsync(int id)
            => await Table.FindAsync(id);
        public async Task<T> GetByIdAsync(Guid id)
            => await Table.FindAsync(id);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method); 

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);
    }
}
