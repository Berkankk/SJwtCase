using AutoMapper;
using SJwtCase.Order.DtoLayer.Dtos.OrderItemDto;
using SJwtCase.Order.EntityLayer.Entities;

namespace SJwtCase.Order.WebApi.Mappings
{
    public class OrderItemMapping : Profile
    {
        public OrderItemMapping()
        {
            CreateMap<OrderItem, ResultOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, CreateOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, UpdateOrderItemDto>().ReverseMap();
        }
    }
}
