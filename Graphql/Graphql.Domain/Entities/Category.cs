using System.ComponentModel.DataAnnotations;

namespace Graphql.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(80)]
        [GraphQLDescription("Name of category")]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        [GraphQLDescription("Url image address of category")]
        public string UrlImage { get; set; }
    }
}
