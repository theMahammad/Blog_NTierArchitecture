using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
	public class ShortlyAbout:ViewComponent
	{
		AboutManager manager = new(new EfAboutRepository());
		public IViewComponentResult Invoke()
		{
			var model = manager.GetAll().FirstOrDefault();
			string aboutDetails = "";
			if (model != null)
			{

				aboutDetails = model.Detail1 + model.Detail2;

			}
			ViewBag.ShortlyAbout = aboutDetails.Substring(0, aboutDetails.Substring(0,75).LastIndexOf(""));
			return View();
		}
	}
}
