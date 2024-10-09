namespace SJwtCase.Discount.Dtos
{
    public class GetCouponByIdDto //id ye göre getirme ya da filtreme işlemi için bunu kullancağız 
    {
        public int CouponID { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountRate { get; set; }
        public DateTime DiscountDate { get; set; }
        public bool IsActive { get; set; }
    }
}
