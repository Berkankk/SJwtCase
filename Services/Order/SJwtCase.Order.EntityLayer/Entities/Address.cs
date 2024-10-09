using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.EntityLayer.Entities
{
    public class Address
    {
        public int AddressID { get; set; }
        public string UserID { get; set; } //string türde tutma sebebim identity de int değerler string olarak tutulduğu için 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string AddressLine { get; set; }
    }
}
