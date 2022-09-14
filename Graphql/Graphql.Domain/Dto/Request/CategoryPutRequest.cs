namespace Graphql.Domain.Dto.Request
{
    public class CategoryPutRequest
    {
        [GraphQLDescription("Id of category")]
        public int CategoryId { get; set; }
        [GraphQLDescription("Name of category")]
        public string Name { get; set; }
        [GraphQLDescription("Url image address of category")]
        public string UrlImage { get; set; }
    }
}
