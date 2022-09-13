using Graphql.Domain.Dto.Request;
using Graphql.Domain.Dto.Response;
using Graphql.Domain.Entities;
using Graphql.Domain.Interfaces.Repositories;
using Graphql.Domain.Interfaces.Services;

namespace Graphql.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryResponse> AddCategory(CategoryRequest request)
        {
            Category newCategory = new Category { Name = request.Name, UrlImage = request.UrlImage };
            Category categoryAdded = await _categoryRepository.AddCategory(newCategory);
            CategoryResponse response = new CategoryResponse
            {
                CategoryId = categoryAdded.CategoryId,
                Name = categoryAdded.Name,
                UrlImage = categoryAdded.UrlImage,
            };
            return response;
        }
    }
}
