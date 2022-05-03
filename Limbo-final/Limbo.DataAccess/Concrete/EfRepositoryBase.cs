using System.Linq.Expressions;
using Limbo.DataAccess.Abstract;
using Limbo.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Limbo.DataAccess.Concrete
{
    public class EfRepositoryBase<T, Tcontext> : IEntityRepository<T>
        where Tcontext : DbContext, new()
        where T : class, IEntity, new()
    {
        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new Tcontext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var context = new Tcontext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public void Add(T entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
