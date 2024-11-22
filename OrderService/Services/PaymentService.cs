using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Shared.DTOs;

namespace OrderService.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient _httpClient;

        public PaymentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> ProcessPaymentAsync(PaymentDTO paymentDto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(paymentDto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7055/api/payments", content);
            return response.IsSuccessStatusCode;
        }
    }
}
