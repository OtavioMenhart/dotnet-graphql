using Graphql.Domain.Entities;

namespace Graphql.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> AddCategory(Category category);
    }
}
