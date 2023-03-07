using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T:class
    {
        protected Context context;
        DbSet<T> DbSetCurrentEntity;
        public GenericRepository()
        {
            context = new Context();
            DbSetCurrentEntity = context.Set<T>();
        }
     
        public void Delete(T t)
        {
           context.Remove(t);
           context.SaveChanges();
        }

      

		public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if( filter== null)
            {
               return DbSetCurrentEntity.ToList();

            }
            else
            {   //Some LINQ methods are not supported from Entity Framework, so this can lead a exception.
                try
                {
					return DbSetCurrentEntity.Where(filter).ToList();
				}
                catch (Exception)
                {

                    return DbSetCurrentEntity.Where(filter.Compile()).ToList();
                }
            }
			
             

		}

		public  T GetById(int id)
        {
            return DbSetCurrentEntity.Find(id);
        }

        public void Insert(T t)
        {
            context.Add(t);
            context.SaveChanges();
        }

		public List<T> List(Expression<Func<T, bool>> filter)
		{
            var data = context.Set<T>().Where(filter).ToList();
            return data;
		}

		public void Update(T t)
        {
            context.Update(t);
            context.SaveChanges();
        }
    }
}
