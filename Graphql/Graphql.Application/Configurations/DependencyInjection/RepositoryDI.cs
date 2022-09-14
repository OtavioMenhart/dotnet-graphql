using Graphql.Data.Context;
using Graphql.Data.Repositories;
using Graphql.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Graphql.Application.Configurations.DependencyInjection
{
    public static class RepositoryDI
    {
        public static void ConfigureDIRepositories(IServiceCollection service)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddJsonFile($"appsettings.{environment}.json", optional: true)
               .Build();

            var connectionString = configuration.
                   GetConnectionString("DefaultConnection");

            service.AddPooledDbContextFactory<AppDbContext>(b => b.UseSqlServer(connectionString));

            service.AddScoped<ICategoryRepository, CategoryRepository>();
        }
    }
}
