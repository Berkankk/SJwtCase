using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SJwtCase.Order.BusinessLayer.Abstract;
using SJwtCase.Order.DtoLayer.Dtos.AddressDto;
using SJwtCase.Order.EntityLayer.Entities;

namespace SJwtCase.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly IMapper _mapper;
        public AddressesController(IAddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GettAll()
        {
            var values = _addressService.TGetList();
            var address = _mapper.Map<List<ResultAddressDto>>(values);
            return Ok(address);
        }
        [HttpGet("{id}")]
        public IActionResult GettAddressById(int id)
        {
            var value = _addressService.TGetById(id);
            var address = _mapper.Map<ResultAddressDto>(value);
            return Ok(address);
        }
        [HttpPost]
        public IActionResult CreateAddress(CreateAddressDto createAddressDto)
        {
            var mapAddress = _mapper.Map<Address>(createAddressDto);
            _addressService.TCreate(mapAddress);
            return Ok("Adres bilgisi oluşturuldu");
        }
        [HttpPut]
        public IActionResult UpdateAddress(UpdateAddressDto updateAddressDto)
        {
            var mapAddress = _mapper.Map<Address>(updateAddressDto);
            _addressService.TUpdate(mapAddress);
            return Ok("Adres bilgisi güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(int id)
        {
            _addressService.TDelete(id);
            return Ok("Adres bilgisi silindi");
        }
    }
}
