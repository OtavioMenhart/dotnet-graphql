using Graphql.Domain.Dto.Request;
using Graphql.Domain.Dto.Response;

namespace Graphql.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<CategoryResponse> AddCategory(CategoryRequest request);
    }
}
