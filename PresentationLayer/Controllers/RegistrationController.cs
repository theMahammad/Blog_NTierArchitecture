using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
namespace PresentationLayer.Controllers
{
    public class RegistrationController : Controller
    {
        WriterManager manager = new WriterManager(new EfWriterRepository());
        CategoryManager c_manager = new CategoryManager(new EfCategoryRepository());
        [HttpGet]
        public IActionResult Index()
        {
            var RegistryViewModel = new RegistryViewModel
            {
                Writer = new Writer(),
                Categories = c_manager.GetAll()
            };
            return View(RegistryViewModel);
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {

            return View();
        }
    }
}
