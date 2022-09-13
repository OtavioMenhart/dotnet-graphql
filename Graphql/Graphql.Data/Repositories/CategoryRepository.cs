using Graphql.Data.Context;
using Graphql.Domain.Entities;
using Graphql.Domain.Interfaces.Repositories;

namespace Graphql.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
