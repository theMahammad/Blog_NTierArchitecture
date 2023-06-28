using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class ContactController : Controller
	{
		ContactManager manager = new(new EfContactRepository()); 
		
		public IActionResult Index()
		{
			return View();
		}
		
		public IActionResult SendMessage(Contact contact)
		{
			
			manager.Insert(contact);
			return this.Ok("Qeşeey");
		}
	}
}
