using SJwtCase.Discount.Dtos;
using SJwtCase.Discount.Entities;

namespace SJwtCase.Discount.Services
{
    public interface ICouponService  //Temel crud işlemlerini geçiyorum burada admin tarafından yapılacak bunlar
    {
        List<ResultCouponDto> GetAllCoupons();

        GetCouponByIdDto GetCountById(int id);

        void CreateCoupon(CreateCouponDto createCouponDto);
        void UpdateCoupon(UpdateCouponDto updateCouponDto);
        void DeleteCoupon(int id);
    }
}
