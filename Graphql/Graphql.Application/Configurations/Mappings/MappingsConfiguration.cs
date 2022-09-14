namespace Graphql.Application.Configurations.Mappings
{
    public static class MappingsConfiguration
    {
        public static void ConfigureMappings(IServiceCollection service)
        {
            service.AddAutoMapper(typeof(CategoryProfile));
        }
    }
}
