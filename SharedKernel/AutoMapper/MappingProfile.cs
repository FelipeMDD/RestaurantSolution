using AutoMapper;
using Shared.DTOs;
using Shared.Models;

namespace Shared
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.ProductName, opt => opt.Ignore()) 
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));

            CreateMap<Product, ProductDTO>();

            CreateMap<Payment, PaymentDTO>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));

            CreateMap<OrderDTO, Order>();
            CreateMap<ProductDTO, Product>();
            CreateMap<PaymentDTO, Payment>();
        }
    }
}