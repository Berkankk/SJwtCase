using SJwtCase.Catalog.Entities;
using SJwtCase.Catalog.Repositories;

namespace SJwtCase.Catalog.Services.CategoryServices
{
    public interface ICategoryService : IRepository<Category>
    {
        //Her entiti için tek tek crud işlemlerini yazmak yerin ırepository oluşturup buraya miras verdim
    }
}
