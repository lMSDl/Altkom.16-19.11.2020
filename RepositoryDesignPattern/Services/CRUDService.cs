using RepositoryDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.Services
{
    public class CRUDService<TEntity, TId> where TEntity : Entity<TId>
    {
        public TId Create(TEntity entity)
        {
            using (var context = new Context())
            {
                entity = context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
            return entity.Id;
        }
        public TEntity Read(TId id)
        {
            using (var context = new Context())
            {
                return context.Set<TEntity>().Find(id);
            }
        }
        public IEnumerable<TEntity> Read()
        {
            using (var context = new Context())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new Context())
            {
                context.Set<TEntity>().Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TId id)
        {
            using (var context = new Context())
            {
                var entity = context.Set<TEntity>().Find(id);
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }
    }
}
