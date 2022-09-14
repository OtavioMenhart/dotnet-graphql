namespace Graphql.Domain.Dto.Response
{
    public class CategoryResponse
    {
        [GraphQLDescription("Id of category")]
        public int CategoryId { get; set; }
        [GraphQLDescription("Name of category")]
        public string Name { get; set; }
        [GraphQLDescription("Url image address of category")]
        public string UrlImage { get; set; }
    }
}
