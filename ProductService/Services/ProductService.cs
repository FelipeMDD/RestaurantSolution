using Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductService.Repositories;

namespace ProductService.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _repository.GetAllProductsAsync();
        }

        public async Task<Product?> GetProductByIdAsync(Guid id)
        {
            return await _repository.GetProductByIdAsync(id);
        }
    }
}
