using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
      
        ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

		public void Insert(Category t)
		{
			categoryDal.Insert(t);
		}

		public void Delete(Category t)
		{
			categoryDal.Delete(t);
		}
		public void Update(Category t)
		{
			categoryDal.Update(t);
		}

		

		

		public Category GetById(int id)
		{
			return categoryDal.GetById(id);
		}

		public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
		{
			return categoryDal.GetAll(filter);
		}

		public List<Category> GetCategoriesWithItsArticles()
		{
			return categoryDal.GetCategoriesWithItsArticles();
		}
	}
}
