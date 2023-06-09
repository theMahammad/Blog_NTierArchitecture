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
		public PartialViewResult BeleIshinIcini()
		{
			return PartialView();
		}
		
		public PartialViewResult PartialCommentList(int articleId)
		{
			var values = manager.GetAll(x => x.ArticleID == articleId);
			return PartialView(values);
		}

	}
}
