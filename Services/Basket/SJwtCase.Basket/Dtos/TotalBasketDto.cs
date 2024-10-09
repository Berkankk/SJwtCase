namespace SJwtCase.Basket.Dtos
{
    public class TotalBasketDto
    {
        public string UserID { get; set; } //identity serverdan dolayı böyle tutuyoruz
        public string? DiscountCode { get; set; }  //boş geçilebilir olarak ayarlıyoruz 
        public int? DiscountRate { get; set; }
        public List<BasketItemDto> BasketItems { get; set; }

        public decimal TotalPrice { get => BasketItems.Sum(x => x.Quantity * x.Price); } //okuma yapcağız burada 
    }
}
