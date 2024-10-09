using Microsoft.EntityFrameworkCore;
using SJwtCase.Order.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.DataAccessLayer.Context
{
    public class OrderContext : DbContext  //Sql bağlantı geçttim
    {
        public OrderContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Ordering> Orderings { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
