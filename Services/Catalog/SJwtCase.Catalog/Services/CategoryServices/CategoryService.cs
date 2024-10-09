using SJwtCase.Catalog.Context;
using SJwtCase.Catalog.Entities;
using SJwtCase.Catalog.Repositories;

namespace SJwtCase.Catalog.Services.CategoryServices
{
    public class CategoryService : Repository<Category>, ICategoryService
    {
        //implemente işlemini repositoryde yaptık zaten buraya miras verdim ve ıcategoryService ı da geçtim  db ye ulaştım
        public CategoryService(CatalogContext catalogContext) : base(catalogContext)
        {
        }
    }
}
