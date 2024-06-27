using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCvEntities entities = new DbCvEntities();

        public List<T> List()
        {
            return entities.Set<T>().ToList();
        }

        public void TAdd(T entity)
        {
            entities.Set<T>().Add(entity);
            entities.SaveChanges();
        }
        public void TDelete(T entity)
        {
            entities.Set<T>().Remove(entity);
            entities.SaveChanges();
        }
        public T TGet(int id)
        {
            return entities.Set<T>().Find(id);
        }
        public void TUpdate(T entity)
        {
            entities.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> where)
        {
            return entities.Set<T>().FirstOrDefault(where);
        }
        
    }
}