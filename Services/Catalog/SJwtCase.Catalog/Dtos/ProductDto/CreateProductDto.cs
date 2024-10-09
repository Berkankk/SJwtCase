using SJwtCase.Catalog.Entities;

namespace SJwtCase.Catalog.Dtos.ProductDto
{
    public class CreateProductDto
    {
     
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }

    }
}
