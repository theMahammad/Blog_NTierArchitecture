using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace PresentationLayer.Controllers
{
	public class LoginController : Controller
	{
		WriterManager manager = new(new EfWriterRepository());
		[HttpGet]
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public IActionResult Index(Writer writer)
		{
			Context context = new Context();
			var loginnedUser = context.Writers.FirstOrDefault(x => x.EmailAdress == writer.EmailAdress &&
			 x.Password == writer.Password);
			if(loginnedUser!=null) {
				HttpContext.Session.SetString("username", loginnedUser.EmailAdress);
				return RedirectToAction("Index", "Article");
			}
			else
			{
				return View();
			}


			
		}

	}
}
