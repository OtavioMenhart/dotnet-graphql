using Graphql.Domain.Dto.Request;
using Graphql.Domain.Dto.Response;

namespace Graphql.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<CategoryResponse> AddCategory(CategoryPostRequest request);
        Task<bool> DeleteCategory(int id);
        Task<CategoryResponse> UpdateCategory(CategoryPutRequest request);
    }
}
