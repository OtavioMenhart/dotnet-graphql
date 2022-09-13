using Graphql.Domain.Entities;

namespace Graphql.Domain.Interfaces.Queries
{
    public interface ICategoryQuery
    {
        Task<IEnumerable<Category>> GetAllCategories();
    }
}
