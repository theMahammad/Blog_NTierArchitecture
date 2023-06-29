using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
	public class LastThreePosts:ViewComponent
	{
		ArticleManager manager = new(new EfArticleRepository());
		public IViewComponentResult Invoke()
		{
			var articles = manager.GetAll();
			articles.Reverse();
			
			var lastThreePosts = articles.Take(3);
			ViewBag.LastThreePosts = lastThreePosts.ToList();
			return View();
		}
	}
}
