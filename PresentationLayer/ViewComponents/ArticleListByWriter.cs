using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
	public class ArticleListByWriter:ViewComponent
	{
		WriterManager w_manager = new(new EfWriterRepository());
		ArticleManager a_manager = new ArticleManager(new EfArticleRepository());
		public IViewComponentResult Invoke(int articleId)
		{ 
			var selectedArticle = a_manager.GetById(articleId);
			var articlesOfselectedWriter = w_manager.GetSelectedWriterWithItsArticles(selectedArticle.WriterId);
			return View(articlesOfselectedWriter);
		}
	}
}
 