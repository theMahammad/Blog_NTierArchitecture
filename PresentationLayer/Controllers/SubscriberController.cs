using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Exceptions;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
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
			try
			{
				manager.Insert(subscriber);
				return this.Ok(new { title = $"Welcome, {subscriber.Email}", text = "You are our subscriber from now! It will be worth it :)" });

			}catch(AlreadySubscriberException ex) {
				var selectedSubscriber = manager.GetByCondition(x=>x.Email == subscriber.Email);
				var response = new { subscriber = selectedSubscriber,title = $"Welcome again, {subscriber.Email}", text = "You have aldready been our subscriber, dear :) Do you want to cancel?" };
				
				return this.BadRequest(response);

			}

		}
		public IActionResult DeleteSubscriber(Subscriber subscriber){
			subscriber = manager.GetById(subscriber.Id);
			manager.Delete(subscriber);
			return this.Ok();
		}
	}
}
