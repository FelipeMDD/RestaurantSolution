using Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(Guid id);
    }
}
