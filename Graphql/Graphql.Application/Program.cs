using Graphql.Application.Configurations.DependencyInjection;
using Graphql.Application.Configurations.Graphql;
using Graphql.Application.Configurations.Mappings;

var builder = WebApplication.CreateBuilder(args);

RepositoryDI.ConfigureDIRepositories(builder.Services);
ServiceDI.ConfigureDIServices(builder.Services);
GraphqlConfiguration.ConfigureGraphql(builder.Services);
MappingsConfiguration.ConfigureMappings(builder.Services);

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
