using AutoMapper;
using Graphql.Domain.Dto.Response;
using Graphql.Domain.Interfaces.Queries;
using Graphql.Domain.Interfaces.Repositories;

namespace Graphql.Service.Queries
{
    public class CategoryQuery : ICategoryQuery
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryQuery(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryResponse>> GetAllCategories()
        {
            IEnumerable<CategoryResponse> allCategories = _mapper.Map<IEnumerable<CategoryResponse>>(await _categoryRepository.SelectAsync());
            return allCategories;
        }

        public async Task<CategoryResponse> GetCategoryById(int id)
        {
            CategoryResponse category = _mapper.Map<CategoryResponse>(await _categoryRepository.SelectAsync(id));
            return category;
        }
    }
}
