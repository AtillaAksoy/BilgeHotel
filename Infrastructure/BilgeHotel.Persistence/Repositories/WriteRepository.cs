using BilgeHotel.Application.Repositories;
using BilgeHotel.Domain.Entities.Common;
using BilgeHotel.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly BilgeHotelContext _context;

        public WriteRepository(BilgeHotelContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
          EntityEntry<T> entityEntry= await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }
        public async Task<int> AddAsyncInt (T entity) //test edilecek
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            await _context.SaveChangesAsync(); // Değişikliklerin veritabanına yansıtılmasını sağla
            return entityEntry.Entity.Id; // Eklendikten sonra entity'nin ID'sini döndür
        }
        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }
        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }
        public async Task<bool> Remove(int id)
        {
            //T model=  await Table.FirstOrDefaultAsync(x => x.Id == id);
            //return Remove(model);
            T model = await Table.FirstOrDefaultAsync(x => x.Id == id);
            model.IsDeleted = true;
            model.IsPassive = true;
            return await Update(model);
        }
        public async Task<bool> Update(T entity)
        {
            var existingEntity = await Table.FindAsync(entity.Id);
            if (existingEntity != null)
            {
                Table.Entry(existingEntity).State = EntityState.Detached; // Takibi bırak
            }

            Table.Update(entity);
            return true;
            //Table.Attach(entity); //nesnenin takibini bırak
            //EntityEntry<T> entityEntry =  Table.Update(entity);
            //return entityEntry.State == EntityState.Modified;  
        }
        public async Task<int> SaveAsync()
            =>  await _context.SaveChangesAsync();
          
    }
}
