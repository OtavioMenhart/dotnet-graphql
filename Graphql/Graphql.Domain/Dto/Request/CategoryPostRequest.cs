namespace Graphql.Domain.Dto.Request
{
    public class CategoryPostRequest
    {
        [GraphQLDescription("Name of category")]
        public string Name { get; set; }
        [GraphQLDescription("Url image address of category")]
        public string UrlImage { get; set; }
    }
}

