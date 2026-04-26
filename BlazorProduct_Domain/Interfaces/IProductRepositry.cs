using BlazorProduct_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProduct_Domain.Interfaces
{
    public interface IProductRepositry
    {
        Task<bool?> CreatProductAsync(Product product);
        Task<bool> DeleteProductAsync(int id);
        Task<List<Product>?> GetAllProductsAsync();
        Task<Product?> GetOneProductAsync(int id);
        Task<bool> UpdateProductAsync(int id, Product product);
    }
}
