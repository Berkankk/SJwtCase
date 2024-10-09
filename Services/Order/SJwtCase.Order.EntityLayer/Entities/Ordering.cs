using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.EntityLayer.Entities
{
    public class Ordering
    {
        public int OrderingID { get; set; }
        public string UserID { get; set; } //identityden dolayı string tuttum
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; } 
    }
}
