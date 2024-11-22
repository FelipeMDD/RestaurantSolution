using AutoMapper;
using OrderService.Repositories;
using Shared.DTOs;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderService.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IProductService _productService;
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IProductService productService, IPaymentService paymentService, IMapper mapper)
        {
            _repository = repository;
            _productService = productService;
            _paymentService = paymentService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderDTO>> GetAllOrdersAsync()
        {
            var orders = await _repository.GetAllOrdersAsync();
            return _mapper.Map<IEnumerable<OrderDTO>>(orders);
        }

        public async Task<OrderDTO> GetOrderByIdAsync(Guid id)
        {
            var order = await _repository.GetOrderByIdAsync(id);
            return _mapper.Map<OrderDTO>(order);
        }

        public async Task CreateOrderAsync(OrderDTO orderDto)
        {
            // Obter detalhes do produto
            var product = await _productService.GetProductByIdAsync(orderDto.Id);

            // Processar o pagamento
            var paymentDto = new PaymentDTO { Amount = product.Price, OrderId = orderDto.Id };
            var paymentSuccess = await _paymentService.ProcessPaymentAsync(paymentDto);

            if (paymentSuccess)
            {
                var order = _mapper.Map<Order>(orderDto);
                await _repository.CreateOrderAsync(order);
            }
            else
            {
                throw new Exception("Payment processing failed.");
            }
        }
    }
}
