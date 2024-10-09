namespace SJwtCase.Discount.Dtos
{
    public class ResultCouponDto //Listelem get
    {
        public int CouponID { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountRate { get; set; }
        public DateTime DiscountDate { get; set; }
        public bool IsActive { get; set; }
    }
}
