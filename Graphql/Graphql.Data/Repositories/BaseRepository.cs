using Graphql.Data.Context;
using Graphql.Domain.Entities;
using Graphql.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Graphql.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        private DbSet<T> _dataSet;

        public BaseRepository(IDbContextFactory<AppDbContext> context)
        {
            _context = context.CreateDbContext();
            _dataSet = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            T result = await _dataSet.SingleOrDefaultAsync(x => x.Id.Equals(id));

            if (result is null)
                return false;

            _dataSet.Remove(result);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await _dataSet.AnyAsync(x => x.Id.Equals(id));
        }

        public async Task<T> InsertAsync(T item)
        {
            await _dataSet.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<T> SelectAsync(int id)
        {
            return await _dataSet.SingleOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            return await _dataSet.ToListAsync();
        }

        public async Task<T> UpdateAsync(T item)
        {
            T result = await _dataSet.SingleOrDefaultAsync(x => x.Id.Equals(item.Id));

            if (result is null)
                return null;

            _context.Entry(result).CurrentValues.SetValues(item);
            await _context.SaveChangesAsync();
            return item;
        }
    }
}
