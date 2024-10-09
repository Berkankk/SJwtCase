using Microsoft.EntityFrameworkCore;
using SJwtCase.Catalog.Entities;
using static Azure.Core.HttpHeader;

namespace SJwtCase.Catalog.Context
{
    public class CatalogContext : DbContext
    {
        
        public CatalogContext(DbContextOptions options) : base(options) //sql bağlantısını appsetting de verdim burada da verebilirdim 
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
