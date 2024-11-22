using Shared.DTOs;
using System.Threading.Tasks;

namespace OrderService.Services
{
    public interface IPaymentService
    {
        Task<bool> ProcessPaymentAsync(PaymentDTO paymentDto);
    }
}