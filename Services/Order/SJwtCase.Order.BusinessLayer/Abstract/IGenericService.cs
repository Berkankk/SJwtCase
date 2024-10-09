using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        //başlarına T yazıyoruz çünkü dal da oluşturduğumuz metotlarla karışmasın diye  burada oluşturduğumuz metotları controller da çağıracağız 
        List<T> TGetList();
        T TGetById(int id);
        void TDelete(int id);
        void TUpdate(T entity);
        void TCreate(T entity);
    }
}
