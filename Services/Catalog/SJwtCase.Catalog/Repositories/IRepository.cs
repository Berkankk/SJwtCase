using System.Linq.Expressions;

namespace SJwtCase.Catalog.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(); //Tamamını getir 
        Task<T> GetByIdAsync(int id); //id ye göre tek değer getir

        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

        Task<List<T>> GetFilteredListAsync(Expression<Func<T, bool>> filter); //filtreleme yaptım list olarak dönecek veri
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter); //Kategori ve ürünlerde bunu kullanacağım 
    }
}
