using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        AboutManager manager = new(new EfAboutRepository());
        public IActionResult Index()
        {
            
            var model = manager.GetAll();
			return View(model);
        }
    }
}
