using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.DtoLayer.Dtos.OrderItemDto
{
    public class CreateOrderItemDto
    {

        public int ProductID { get; set; }  //ilişki kurmadık çünkü başka bir service de çalışıyor product
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get => Quantity * Price; } //Sadece okunabilir ben müdehale edemem  ve kendisi hesaplasın o yüzden bunu verdim 
        public int OrderingID { get; set; }
      

    }
}
