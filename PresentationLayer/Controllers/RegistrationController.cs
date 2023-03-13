using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class RegistrationController : Controller
    {
        WriterManager manager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(Writer writer)
        {
            manager.Insert(writer);
            return RedirectToAction("Index","Home");
        }
    }
}
