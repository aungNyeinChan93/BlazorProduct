using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorProduct_Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public required string Name { get; set; }

        [Range(0,1000000)]
        public decimal Price { get; set; }

        public bool isStock { get; set; } = false;

        public Category? Category { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

    }
}
