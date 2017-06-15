using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private ManagerContext db;
        private DbSet<T> dbSet;

        public BaseRepository()
        {
            db = new ManagerContext();
            dbSet = db.Set<T>();
        }

        public virtual List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter).ToList();
        }

        public virtual T Get(Expression<Func<T, bool>> filter)
        {
            return dbSet.FirstOrDefault(filter);
        }

        public void Insert(T entity)
        {
            dbSet.Add(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
            db.SaveChanges();
        }
    }
}
