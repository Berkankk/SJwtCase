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
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(OrderContext context) : base(context)
        {
        }
    }
}
