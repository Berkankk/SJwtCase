using Microsoft.EntityFrameworkCore;
using SJwtCase.Discount.Entities;

namespace SJwtCase.Discount.Context
{
    public class DiscountContext : DbContext
    {
        //Sql bağlantısını burada yapıyoruz, bağlantıyı appsettings de veriyorum 
        public DiscountContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Coupon> Coupons { get; set; } //Sql de gösterimini yazdık 


    }
}
