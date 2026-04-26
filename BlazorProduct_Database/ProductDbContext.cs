using BlazorProduct_Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProduct_Database
{
    public class ProductDbContext: DbContext
    {

        public ProductDbContext() { }

        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
