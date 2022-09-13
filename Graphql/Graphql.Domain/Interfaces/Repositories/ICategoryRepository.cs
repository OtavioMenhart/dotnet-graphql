using Graphql.Domain.Entities;

namespace Graphql.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
    }
}
