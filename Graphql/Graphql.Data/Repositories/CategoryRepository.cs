using Graphql.Data.Context;
using Graphql.Domain.Entities;
using Graphql.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Graphql.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly DbSet<Category> _dataSet;

        public CategoryRepository(IDbContextFactory<AppDbContext> context) : base(context)
        {
            _dataSet = context.CreateDbContext().Set<Category>();
        }

    }
}
