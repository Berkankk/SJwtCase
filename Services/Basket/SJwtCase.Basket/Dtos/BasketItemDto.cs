namespace SJwtCase.Basket.Dtos
{
    public class BasketItemDto
    {
        public int ProductID { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
