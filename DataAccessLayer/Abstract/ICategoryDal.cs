using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        public void Delete(Category t)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            int a = 5;
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category t)
        {
            throw new NotImplementedException();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
