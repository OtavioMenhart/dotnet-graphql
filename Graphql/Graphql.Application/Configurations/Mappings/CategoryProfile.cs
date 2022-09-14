using AutoMapper;
using Graphql.Domain.Dto.Request;
using Graphql.Domain.Dto.Response;
using Graphql.Domain.Entities;

namespace Graphql.Application.Configurations.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryRequest, Category>();
            CreateMap<Category, CategoryResponse>();
        }
    }
}
