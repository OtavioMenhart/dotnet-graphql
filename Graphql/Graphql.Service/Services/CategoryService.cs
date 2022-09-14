using AutoMapper;
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
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryResponse> AddCategory(CategoryPostRequest request)
        {
            Category newCategory = _mapper.Map<Category>(request);
            Category categoryAdded = await _categoryRepository.InsertAsync(newCategory);
            CategoryResponse response = _mapper.Map<CategoryResponse>(categoryAdded);
            return response;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            await VerifyIfExists(id);

            bool deleted = await _categoryRepository.DeleteAsync(id);
            return deleted;
        }

        public async Task<CategoryResponse> UpdateCategory(CategoryPutRequest request)
        {
            await VerifyIfExists(request.CategoryId);
            Category categoryToUpdate = _mapper.Map<Category>(request);
            categoryToUpdate = await _categoryRepository.UpdateAsync(categoryToUpdate);
            return _mapper.Map<CategoryResponse>(categoryToUpdate);
        }
        private async Task VerifyIfExists(int id)
        {
            bool exist = await _categoryRepository.ExistAsync(id);
            if (!exist)
                throw new KeyNotFoundException("Category doesn't exists");
        }
    }
}
