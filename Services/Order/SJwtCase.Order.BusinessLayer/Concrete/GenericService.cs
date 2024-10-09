using SJwtCase.Order.BusinessLayer.Abstract;
using SJwtCase.Order.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.BusinessLayer.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        //dalı çağırıyoruz burada 
        private readonly IRepository<T> _repository;

        public GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void TCreate(T entity)
        {
            _repository.Create(entity); //Daldan geldi

        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public T TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<T> TGetList()
        {
            return _repository.GetList();
        }

        public void TUpdate(T entity)
        {
            _repository.Update(entity);
        }
    }
}
