using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using System.Linq.Expressions;

namespace PresentationLayer.ViewComponents
{
	public class CommentListByBlog:ViewComponent
	{
		CommentManager manager = new(new EfCommentRepository());
		public IViewComponentResult Invoke(int articleId)
		{
			var comments = manager.GetAll(x => x.ArticleID == articleId);
			return View(comments);
		}
	}
}
