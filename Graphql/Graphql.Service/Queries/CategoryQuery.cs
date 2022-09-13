using Graphql.Domain.Entities;
using Graphql.Domain.Interfaces.Queries;
using Graphql.Domain.Interfaces.Repositories;

namespace Graphql.Service.Queries
{
    public class CategoryQuery : ICategoryQuery
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryQuery(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }
    }
}
