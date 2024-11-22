using Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(Guid id);
    }
}
