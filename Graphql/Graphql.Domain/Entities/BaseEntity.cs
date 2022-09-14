using System.ComponentModel.DataAnnotations;

namespace Graphql.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [GraphQLDescription("Id")]
        public int Id { get; set; }
    }
}
