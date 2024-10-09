using AutoMapper;
using SJwtCase.Order.DtoLayer.Dtos.OrderingDto;
using SJwtCase.Order.EntityLayer.Entities;

namespace SJwtCase.Order.WebApi.Mappings
{
    public class OrderingMapping : Profile
    {
        public OrderingMapping()
        {
            CreateMap<Ordering, UpdateOrderingDto>().ReverseMap();
            CreateMap<Ordering, CreateOrderingDto>().ReverseMap();
            CreateMap<Ordering, ResultOrderingDto>().ReverseMap();
        }
    }
}
