using AutoMapper;
using PaymentService.Repositories;
using Shared.DTOs;
using Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PaymentService.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _repository;
        private readonly IMapper _mapper;

        public PaymentService(IPaymentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync()
        {
            var payments = await _repository.GetAllPaymentsAsync();
            return _mapper.Map<IEnumerable<PaymentDTO>>(payments);
        }

        public async Task<PaymentDTO> GetPaymentByIdAsync(string id)
        {
            var payment = await _repository.GetPaymentByIdAsync(id);
            return _mapper.Map<PaymentDTO>(payment);
        }

        public async Task CreatePaymentAsync(PaymentDTO paymentDto)
        {
            var payment = _mapper.Map<Payment>(paymentDto);
            await _repository.CreatePaymentAsync(payment);
        }
    }
}
