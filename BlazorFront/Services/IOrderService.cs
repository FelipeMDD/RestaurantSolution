using Shared.DTOs;

namespace BlazorFront.Services
{
    public interface IOrderService
    {
        Task<List<OrderDTO>> GetOrdersAsync();
        Task CreateOrderAsync(OrderDTO order);
    }
}
