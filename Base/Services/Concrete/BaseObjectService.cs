using Base.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Base.Services.Concrete
{
    public class BaseObjectService<T> : IBaseObjectService<T> where T : BaseObject
    {
        private readonly DbContext _context;

        public BaseObjectService(DbContext context)
        {
            _context = context;
        }

        public T Get(int id)
        {
             return _context.Set<T>().Find(id);
            throw new System.NotImplementedException();
        }

        public T Create(T obj)
        {
            throw new System.NotImplementedException();
        }

        public T Update(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
