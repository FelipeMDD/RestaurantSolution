using BlazorFront.Services;
using Shared.DTOs;
using System.Net.Http.Json;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ProductDTO>> GetProductsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<ProductDTO>>("api/products");
    }
}


