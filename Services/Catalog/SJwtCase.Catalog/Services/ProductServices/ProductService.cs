using SJwtCase.Catalog.Context;
using SJwtCase.Catalog.Entities;
using SJwtCase.Catalog.Repositories;

namespace SJwtCase.Catalog.Services.ProductServices
{
    public class ProductService : Repository<Product>, IProductService
    {
        //repository içinde ctor geçtiğimiz için burada ctor geçmek zorundayız
        public ProductService(CatalogContext catalogContext) : base(catalogContext)
        {
        }
    }
}
