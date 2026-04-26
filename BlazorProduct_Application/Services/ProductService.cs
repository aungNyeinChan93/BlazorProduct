using BlazorProduct_Domain.Entities;
using BlazorProduct_Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProduct_Application.Services
{
    public class ProductService :IProductService
    {
        private readonly IProductRepositry _productRepo;

        public ProductService(IProductRepositry productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<List<Product>?> GetAllProductsAsync()
        {
            var products = await _productRepo.GetAllProductsAsync();
            return products;
        }

        public async Task<Product> GetOneProductAsync(int id)
        {
            return default!;
        }

        public async Task<bool> CreateProductAsync(Product product)
        {
            return default!;
        }

        public async Task<bool> UpdaProductAsync(Product product)
        {
            return default!;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            return default!;
        }
    }
}
