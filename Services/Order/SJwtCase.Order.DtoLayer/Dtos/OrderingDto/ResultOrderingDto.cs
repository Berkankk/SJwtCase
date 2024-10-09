using SJwtCase.Order.DtoLayer.Dtos.OrderItemDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.DtoLayer.Dtos.OrderingDto
{
    public class ResultOrderingDto
    {
        public int OrderingID { get; set; }
        public string UserID { get; set; } //identityden dolayı string tuttum
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<ResultOrderItemDto> OrderItems { get; set; }
    }
}
