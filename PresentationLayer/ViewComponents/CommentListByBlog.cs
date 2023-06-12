using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;
using System.Linq.Expressions;

namespace PresentationLayer.ViewComponents
{
	public class CommentListByBlog:ViewComponent
	{
		CommentManager manager = new(new EfCommentRepository());
		public IViewComponentResult Invoke(int articleId)
		{
			var model = new CommentViewModel()
			{
				Comments = manager.GetAll(x => x.ArticleID == articleId),
				ArticleID = articleId
			};
			

			return View(model);
		}
	}
}
