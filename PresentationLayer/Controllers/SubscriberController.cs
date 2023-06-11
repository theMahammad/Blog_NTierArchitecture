using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace PresentationLayer.Controllers
{
	public class SubscriberController : Controller
	{
		SubscriberManager manager = new(new EfSubscriberRepository());
		public IActionResult Index()
		{
			return View();
		}
		
		public IActionResult AddSubscriber(Subscriber subscriber)
		{
			manager.Insert(subscriber);
			return this.Ok("Qəşəəy");


		}
	}
}
