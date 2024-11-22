using BlazorFront.Services;
using Shared.DTOs;
using System.Net.Http.Json;

public class OrderService : IOrderService
{
    private readonly HttpClient _httpClient;

    public OrderService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<OrderDTO>> GetOrdersAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<OrderDTO>>("api/orders");
    }

    public async Task CreateOrderAsync(OrderDTO order)
    {
        await _httpClient.PostAsJsonAsync("api/orders", order);
    }
}


