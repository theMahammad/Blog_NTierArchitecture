using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCatRepo;
        public CategoryManager()
        {
            efCatRepo = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            efCatRepo.Add(category);
        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
