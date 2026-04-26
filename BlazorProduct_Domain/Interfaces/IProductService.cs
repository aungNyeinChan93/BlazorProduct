using BlazorProduct_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProduct_Domain.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int id);
        Task<List<Product>?> GetAllProductsAsync();
        Task<Product> GetOneProductAsync(int id);
        Task<bool> UpdaProductAsync(Product product);
    }
}
