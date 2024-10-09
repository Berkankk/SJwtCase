using SJwtCase.Catalog.Entities;
using SJwtCase.Catalog.Repositories;

namespace SJwtCase.Catalog.Services.ProductServices
{
    public interface IProductService : IRepository<Product>
    {
    }
}
