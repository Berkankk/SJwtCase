namespace SJwtCase.Discount.Dtos
{
    public class UpdateCouponDto //güncelleme post 
    {
        public int CouponID { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountRate { get; set; }
        public DateTime DiscountDate { get; set; }
        public bool IsActive { get; set; }
    }
}
