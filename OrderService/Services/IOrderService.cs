using Shared.DTOs;

namespace OrderService.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetAllOrdersAsync();
        Task<OrderDTO> GetOrderByIdAsync(Guid id);
        Task CreateOrderAsync(OrderDTO orderDto);
    }
}
