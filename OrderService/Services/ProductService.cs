using System;
using System.Net.Http;
using System.Threading.Tasks;
using Shared.DTOs;
using Newtonsoft.Json;

namespace OrderService.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductDTO> GetProductByIdAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:7104/api/products/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Unable to retrieve product.");
            }

            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ProductDTO>(jsonString);
        }
    }
}
