using Shared.DTOs;

namespace BlazorFront.Services
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetProductsAsync();
    }
}
