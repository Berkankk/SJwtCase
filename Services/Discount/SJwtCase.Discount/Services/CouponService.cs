using Microsoft.AspNetCore.Authentication;
using SJwtCase.Discount.Context;
using SJwtCase.Discount.Dtos;
using SJwtCase.Discount.Entities;

namespace SJwtCase.Discount.Services
{
    public class CouponService : ICouponService  //implement işlemini gerçekleştireceğiz, db de ctor üreteceğiz ,tek bir class olduğu için manuel mapping işlemini yapıyorum.
    {
        private readonly DiscountContext _discountContext;

        public CouponService(DiscountContext discountContext)
        {
            _discountContext = discountContext;
        }

        public void CreateCoupon(CreateCouponDto createCouponDto)
        {
            var coupon = new Coupon()  //tek tek atama işlemi yapıyorum createde olanlarla  , manuel mapping yaptım automapper yüklemedim buraya
            {
                DiscountCode = createCouponDto.DiscountCode,
                DiscountRate = createCouponDto.DiscountRate,
                IsActive = createCouponDto.IsActive,
                DiscountDate = createCouponDto.DiscountDate,
            };
            _discountContext.Add(coupon);
            _discountContext.SaveChanges();

        }

        public void DeleteCoupon(int id)
        {
            var value = _discountContext.Coupons.Find(id);  //id ye göre değeri yakala  , yakaladığın değeri value a ata 
            _discountContext.Coupons.Remove(value); //value da yakaladığın değere hoşçakal de
            _discountContext.SaveChanges(); //değişiklikleri kaydet

        }

        public List<ResultCouponDto> GetAllCoupons()
        {
           var values = _discountContext.Coupons.ToList();  //Couponda olanları liste oalrak getir ve sonrasında mapleme işlemi yapacağım 

            return(from x in values select new ResultCouponDto  //manuel mapleme işlemi tüm kuponları listelem işlemi
            {
                CouponID = x.CouponID,
                DiscountCode=x.DiscountCode,
                IsActive=x.IsActive,
                DiscountRate=x.DiscountRate,
                DiscountDate=x.DiscountDate,
            }).ToList();

        }

        public GetCouponByIdDto GetCountById(int id)
        {
            var value = _discountContext.Coupons.Find(id);
            return new GetCouponByIdDto //Gelen değerler ile valuedan gelen değerleri mepliyoruz 
            {
                CouponID= value.CouponID,
                DiscountDate= value.DiscountDate,
                IsActive= value.IsActive,
                DiscountRate= value.DiscountRate,
                DiscountCode = value.DiscountCode,
            };
        }

        public void UpdateCoupon(UpdateCouponDto updateCouponDto)
        {
            var coupon = new Coupon()
            {
                CouponID = updateCouponDto.CouponID,
                DiscountDate = updateCouponDto.DiscountDate,
                IsActive = updateCouponDto.IsActive,
                DiscountRate = updateCouponDto.DiscountRate,
                DiscountCode = updateCouponDto.DiscountCode,
            };
            _discountContext.Coupons.Update(coupon);
            _discountContext.SaveChanges();  //Aynı create işleminde ki gibi olan verileri dtodan gelen verilere atadık ve değişiklikleri kaydettik
        }
    }
}
