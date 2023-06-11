using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager manager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var categories = manager.GetAll();
            return View(categories);
        }
        public IActionResult AddCategory(Category category)
        {
            manager.Insert(category);
            return this.Ok("Afərin");
        }
    }
}
