using Graphql.Data.Context;
using Graphql.Data.Repositories;
using Graphql.Domain.Interfaces.Queries;
using Graphql.Domain.Interfaces.Repositories;
using Graphql.Service.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryQuery, CategoryQuery>();

builder.Services.AddGraphQLServer().AddQueryType<CategoryQuery>();

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
