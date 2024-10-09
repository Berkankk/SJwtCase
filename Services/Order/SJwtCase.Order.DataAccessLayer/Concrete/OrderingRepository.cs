using SJwtCase.Order.DataAccessLayer.Abstract;
using SJwtCase.Order.DataAccessLayer.Context;
using SJwtCase.Order.DataAccessLayer.Repositories;
using SJwtCase.Order.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.DataAccessLayer.Concrete
{
    public class OrderingRepository : Repository<Ordering>, IOrderingRepository
    {
        public OrderingRepository(OrderContext context) : base(context)
        {
            //ıorderingrepository i geçmemizin sebebi entitiye özgü metot yazarsak burada implement etmek için yazıyoruz 
        }
    }
}
