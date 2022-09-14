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

        public async Task<CategoryResponse> AddCategory(CategoryRequest request)
        {
            Category newCategory = _mapper.Map<Category>(request);
            Category categoryAdded = await _categoryRepository.AddCategory(newCategory);
            CategoryResponse response = _mapper.Map<CategoryResponse>(categoryAdded);
            return response;
        }
    }
}
