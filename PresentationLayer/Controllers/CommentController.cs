using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
	public class CommentController : Controller
	{
		CommentManager manager = new (new EfCommentRepository());	
		public IActionResult Index()
		{
			
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
	
		
		public PartialViewResult PartialCommentList(int articleId)
		{
			var values = manager.GetAll(x => x.ArticleID == articleId);
			return PartialView(values);
		}
		public IActionResult AddComment(Comment comment)
		{
			manager.Insert(comment);
			var addedComment = manager.GetAll(x => x.ArticleID == comment.ArticleID).Last();

			return Json(addedComment);
		}

	}
}
