using SJwtCase.Catalog.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using SJwtCase.Catalog.Migrations;

namespace SJwtCase.Catalog.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CatalogContext _catalogContext;

        public Repository(CatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }


        public async Task CreateAsync(T entity)
        {
            await _catalogContext.Set<T>().AddAsync(entity);   // Veriyi ekler 
            await _catalogContext.SaveChangesAsync();          // Değişiklikleri kaydeder
        }


        public async Task DeleteAsync(int id)
        {
            var entity = await _catalogContext.Set<T>().FindAsync(id);  // Id'ye göre bulur
            _catalogContext.Set<T>().Remove(entity);  // Sil
            await _catalogContext.SaveChangesAsync(); 

        }


        public async Task<List<T>> GetAllAsync()
        {
            return await _catalogContext.Set<T>().ToListAsync();  // Tüm verileri getirir
        }

        public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _catalogContext.Set<T>().FirstOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _catalogContext.Set<T>().FindAsync(id);  // Id'ye göre veri getirir
        }

        public async Task<List<T>> GetFilteredListAsync(Expression<Func<T, bool>> filter)
        {
            return await _catalogContext.Set<T>().Where(filter).ToListAsync();  // Listeleme için Where(Sorgu içinde) ve ToListAsync(Listeleme) kullanılır
        }

        public async Task UpdateAsync(T entity)
        {
            _catalogContext.Set<T>().Update(entity);
            await _catalogContext.SaveChangesAsync();
        }
    }
}
