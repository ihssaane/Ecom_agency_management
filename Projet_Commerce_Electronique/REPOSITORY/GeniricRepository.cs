using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinique_CF.INTERFACES;

namespace Clinique_CF.REPOSITORY
{
    public class GeniricRepository<T> : IGeniricRepository<T> where T : class
    {
        private DbContext context;
        private DbSet<T> set;

        public GeniricRepository(DbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }
        public void deleteByID(T entity)
        {
            set.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return set.ToList();
        }

        public T getByID(int id)
        {
            return set.Find(id);
        }

        public void insert(T entity)
        {
            set.Add(entity);
            context.SaveChanges();
        }

        public void update(T entity)
        {
            set.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
