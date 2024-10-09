using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        T GetById(int id);
        void Delete(int id);
        void Update(T entity);
        void Create(T entity);  
    }
}
