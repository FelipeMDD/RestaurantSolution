using Shared.DTOs;

namespace PaymentService.Services
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync();
        Task<PaymentDTO> GetPaymentByIdAsync(string id);
        Task CreatePaymentAsync(PaymentDTO paymentDto);
    }
}
