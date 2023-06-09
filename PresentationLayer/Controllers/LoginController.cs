using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace PresentationLayer.Controllers
{
	public class LoginController : Controller
	{
		WriterManager manager = new(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			
			return View();
		}

	}
}
