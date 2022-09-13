﻿using System.ComponentModel.DataAnnotations;

namespace Graphql.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; }
        [Required]
        [StringLength(300)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [StringLength(300)]
        public string UrlImage { get; set; }
        public float Stock { get; set; }
        public DateTime CreatedDate { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}