using Graphql.Domain.Interfaces.Queries;
using Graphql.Service.Queries;
using Graphql.Service.Services;

namespace Graphql.Application.Configurations.Graphql
{
    public static class GraphqlConfiguration
    {
        public static void ConfigureGraphql(IServiceCollection service)
        {
            service.AddScoped<ICategoryQuery, CategoryQuery>();
            service.AddGraphQLServer()
                            .AddQueryType<CategoryQuery>()
                            .AddMutationType<CategoryService>();
        }
    }
}
