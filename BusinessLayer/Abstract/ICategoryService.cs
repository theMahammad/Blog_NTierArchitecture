using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        public void CategoryAdd(Category category);
        public void CategoryUpdate(Category category);
        public void CategoryDelete(Category category);
        public List<Category> GetAllCategories();
        public Category GetCategoryById(int id);
    }
}
