using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.DtoLayer.Dtos.OrderingDto
{
    public class CreateOrderingDto
    {
      
        public string UserID { get; set; } //identityden dolayı string tuttum
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
 
    }
}
