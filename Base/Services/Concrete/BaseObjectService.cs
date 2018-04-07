using Base.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Base.Services.Concrete
{
    public class BaseObjectService<T> : IBaseObjectService<T> where T : BaseObject
    {
        private readonly DbContext _context;

        public BaseObjectService(DbContext context)
        {
            _context = context;
        }

        private DbSet<T> DbSet => _context.Set<T>();

        public virtual T Get(int id)
        {
            return DbSet.Find(id);
        }

        public virtual T Create(T obj)
        {
            return DbSet.Add(obj).Entity;
        }

        public virtual T Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            return Get(obj.Id);
        }

        public virtual void Delete(T obj)
        {
            DbSet.Remove(obj);
        }
    }
}
