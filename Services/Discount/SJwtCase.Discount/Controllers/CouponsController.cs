using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SJwtCase.Discount.Dtos;
using SJwtCase.Discount.Services;

namespace SJwtCase.Discount.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly ICouponService _couponService;   //crud işlemleri için gerekli :) metotlar burada 

        public CouponsController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet]
        public IActionResult GetAllCoupons()
        {
            var values = _couponService.GetAllCoupons();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCouponById(int id)
        {
            var value = _couponService.GetCountById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCoupon(CreateCouponDto createCouponDto)
        {
            _couponService.CreateCoupon(createCouponDto);
            return Ok("Kupon başarıyla eklendi");
        }
        [HttpPut]
        public IActionResult UpdateCoupon(UpdateCouponDto updateCouponDto)
        {
            _couponService.UpdateCoupon(updateCouponDto);
            return Ok("Kupon başarıyla güncellendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCoupon(int id)
        {
            _couponService.DeleteCoupon(id);
            return Ok("Kupon başarıyla silindi");
        }

    }
}
