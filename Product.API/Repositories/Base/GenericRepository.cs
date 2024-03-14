

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Product.API.Data;

namespace Product.API.Repositories.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
            => _context = context;

        public async ValueTask<T> AddAsync(T entity)
        {
            EntityEntry<T> entryEntity = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entryEntity.Entity;
        }

        public async ValueTask<T> DeleteAsync(T entity)
        {
            EntityEntry<T> entryEntity = _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return entryEntity.Entity;
        }

        public async ValueTask<T> GetAsync(int id)
            => _context.Set<T>().Find(id);

        public async ValueTask<List<T>> GetAsync()
            => await _context.Set<T>().ToListAsync();

        public async ValueTask<T> UpdateAsync(T entity)
        {
            EntityEntry<T> entryEntity = _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();

            return entryEntity.Entity;
        }
    }
}
