using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T:class
    {
        Context context;
        DbSet<T> DbSetCurrentEntity;
        public GenericRepository()
        {
            context = new Context();
            DbSetCurrentEntity = context.Set<T>();
        }
        public void Add(T t)
        {
            context.Add(t);
            context.SaveChanges();

        }
        public void Delete(T t)
        {
           context.Remove(t);
           context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return DbSetCurrentEntity.ToList();
        }

        public T GetById(int id)
        {
            return DbSetCurrentEntity.Find(id);
        }

        public void Insert(T t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.Update(t);
            context.SaveChanges();
        }
    }
}
