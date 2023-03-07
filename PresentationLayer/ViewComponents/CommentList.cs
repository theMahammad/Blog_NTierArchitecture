using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using System.Linq.Expressions;

namespace PresentationLayer.ViewComponents
{
	public class CommentList:ViewComponent
	{
		CommentManager manager = new(new EfCommentRepository());
		public IViewComponentResult Invoke(char cr)
		{
			var comments = manager.GetAll().Where(x=> x.Username.StartsWith(cr));
			return View(comments);
		}
	}
}
