using System.Threading.Tasks;
using Shared.DTOs;

namespace OrderService.Services
{
    public interface IProductService
    {
        Task<ProductDTO> GetProductByIdAsync(Guid id);
    }
}