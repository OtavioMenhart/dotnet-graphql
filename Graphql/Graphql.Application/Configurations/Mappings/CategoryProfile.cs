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
            CreateMap<CategoryPostRequest, Category>();
            CreateMap<Category, CategoryResponse>().ForMember(r => r.CategoryId, opt => opt.MapFrom(src => src.Id));
            CreateMap<CategoryPutRequest, Category>().ForMember(r => r.Id, opt => opt.MapFrom(src => src.CategoryId));
        }
    }
}
