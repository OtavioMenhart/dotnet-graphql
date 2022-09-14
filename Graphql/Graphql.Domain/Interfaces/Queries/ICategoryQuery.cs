using Graphql.Domain.Dto.Response;

namespace Graphql.Domain.Interfaces.Queries
{
    public interface ICategoryQuery
    {
        Task<IEnumerable<CategoryResponse>> GetAllCategories();
        Task<CategoryResponse> GetCategoryById(int id);
    }
}
