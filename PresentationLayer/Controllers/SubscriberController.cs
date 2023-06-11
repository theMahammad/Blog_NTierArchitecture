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
		[HttpPost]
		public object AddSubscriber(Subscriber subscriber)
		{
			
			
				
				subscriber.SubscribingBeginDate = DateTime.Now;
				manager.Insert(subscriber);

			return PartialView();


		}
	}
}
