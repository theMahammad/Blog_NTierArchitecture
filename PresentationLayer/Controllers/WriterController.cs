using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
