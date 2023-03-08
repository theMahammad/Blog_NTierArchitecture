using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

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
			subscriber.SubscribingBeginDate = DateTime.Now;
			manager.Insert(subscriber);
			return RedirectToAction("Index","Article");
		}
	}
}
