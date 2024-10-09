using SJwtCase.Order.DataAccessLayer.Abstract;
using SJwtCase.Order.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJwtCase.Order.DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class //implement işlemini yapacağım  ve dbden ctor geçiyorum
    {
        private readonly OrderContext _context;

        public Repository(OrderContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = GetById(id); //id ye göre bul
            _context.Remove(value);  //Bulduğun değeri value değerine atadıktan sonra elveda de 
            _context.SaveChanges(); //Değişiklikleri kaydet
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }


}
