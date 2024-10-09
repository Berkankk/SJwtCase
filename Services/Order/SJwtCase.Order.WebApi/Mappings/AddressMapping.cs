using AutoMapper;
using SJwtCase.Order.DtoLayer.Dtos.AddressDto;
using SJwtCase.Order.EntityLayer.Entities;

namespace SJwtCase.Order.WebApi.Mappings
{
    public class AddressMapping : Profile
    {
        public AddressMapping()
        {
            CreateMap<Address, CreateAddressDto>().ReverseMap(); //Tersine maple dedim
            CreateMap<Address, UpdateAddressDto>().ReverseMap();
            CreateMap<Address, ResultAddressDto>().ReverseMap();
        }
    }
}
