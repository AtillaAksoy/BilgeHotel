using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task<int> AddAsyncInt(T entity);
        Task<bool> AddRangeAsync(List<T> datas);
        Task<bool> Update(T entity);
        Task<bool> Remove(int id);
        bool Remove(T entity);
        Task<int> SaveAsync();

    }
}
