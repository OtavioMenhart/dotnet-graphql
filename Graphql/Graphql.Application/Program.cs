using Graphql.Data.Context;
using Graphql.Data.Repositories;
using Graphql.Domain.Interfaces.Queries;
using Graphql.Domain.Interfaces.Repositories;
using Graphql.Domain.Interfaces.Services;
using Graphql.Service.Queries;
using Graphql.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
IConfigurationRoot configuration = new ConfigurationBuilder()
   .SetBasePath(Directory.GetCurrentDirectory())
   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
   .AddJsonFile($"appsettings.{environment}.json", optional: true)
   .Build();

var connectionString = configuration.
       GetConnectionString("DefaultConnection");

builder.Services.AddPooledDbContextFactory<AppDbContext>(b => b.UseSqlServer(connectionString));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryQuery, CategoryQuery>();
builder.Services.AddTransient<ICategoryService, CategoryService>();


builder.Services.AddGraphQLServer()
                .AddQueryType<CategoryQuery>()
                .AddMutationType<CategoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});


app.Run();
