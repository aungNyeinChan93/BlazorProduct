using BlazorProduct_Domain.Entities;
using BlazorProduct_Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProduct_Database.Repos
{
    public class ProductRepositry : IProductRepositry
    {
        private readonly ProductDbContext _context;

        public ProductRepositry(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>?> GetAllProductsAsync()
        {
            var products = await _context.Products.AsNoTracking().ToListAsync();
            return products;
        }

        public async Task<Product?> GetOneProductAsync(int id)
        {
            var product = await _context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.ProductId == id);
            return product;
        }

        public async Task<bool?> CreatProductAsync(Product product)
        {
            await _context.Products.AddAsync(product!);
            var res = await _context.SaveChangesAsync();
            return res >= 1 ? true : false;
        }

        public async Task<bool> UpdateProductAsync(int id, Product product)
        {
            var p = await _context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.ProductId == id);
            p.Name = product.Name;
            p.Price = product.Price;
            p.CategoryId = product.CategoryId;
            _context.Entry(p).State = EntityState.Modified;
            var res = await _context.SaveChangesAsync();
            return res >= 1 ? true : false;

        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var p = await _context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.ProductId == id);
            _context.Entry(p!).State = EntityState.Deleted;
            var res = await _context.SaveChangesAsync();
            return res >= 1 ? true : false;
        }
    }
}
