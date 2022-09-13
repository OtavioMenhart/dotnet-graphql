using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Graphql.Domain.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [MaxLength(300)]
        public string UrlImage { get; set; }
    }
}
