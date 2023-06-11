using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
	public class SubscribeMail:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
