using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
	public class RecentPost:ViewComponent
	{
		ArticleManager manager = new ArticleManager(new EfArticleRepository());
		public IViewComponentResult Invoke()
		{
			var recentArticle = manager.GetRecent();
			return View(recentArticle);
		}
	}
}
