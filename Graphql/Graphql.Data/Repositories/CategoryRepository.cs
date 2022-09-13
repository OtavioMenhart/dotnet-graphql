using Graphql.Data.Context;
using Graphql.Domain.Entities;
using Graphql.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Graphql.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(IDbContextFactory<AppDbContext> context)
        {
            _context = context.CreateDbContext();
        }

        public async Task<Category> AddCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
