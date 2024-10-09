using SJwtCase.Order.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.DataAccessLayer.Abstract
{
    public interface IOrderingRepository : IRepository<Ordering>
    {
        //bu sınıfa özel metot oluşursa diye entitiye özel interface oluşturdum
    }
}
