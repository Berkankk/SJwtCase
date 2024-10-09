namespace SJwtCase.Discount.Dtos
{
    public class CreateCouponDto  //oluşturma post
    {
        public string DiscountCode { get; set; }
        public int DiscountRate { get; set; }
        public DateTime DiscountDate { get; set; }
        public bool IsActive { get; set; }
    }
}
