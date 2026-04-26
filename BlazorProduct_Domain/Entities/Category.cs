using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorProduct_Domain.Entities
{
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }

        [Required]
        public required string Name { get; set; }

        public List<Product>? Products { get; set; }


    }
}
