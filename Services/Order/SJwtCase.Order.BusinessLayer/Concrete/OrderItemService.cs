﻿using SJwtCase.Order.BusinessLayer.Abstract;
using SJwtCase.Order.DataAccessLayer.Abstract;
using SJwtCase.Order.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.BusinessLayer.Concrete
{
    public class OrderItemService : GenericService<OrderItem>, IOrderItemService
    {
        public OrderItemService(IRepository<OrderItem> repository) : base(repository)
        {
        }
    }
}