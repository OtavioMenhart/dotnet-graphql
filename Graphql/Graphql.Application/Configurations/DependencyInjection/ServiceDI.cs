using Graphql.Domain.Interfaces.Services;
using Graphql.Service.Services;

namespace Graphql.Application.Configurations.DependencyInjection
{
    public static class ServiceDI
    {
        public static void ConfigureDIServices(IServiceCollection service)
        {
            service.AddTransient<ICategoryService, CategoryService>();
        }
    }
}
