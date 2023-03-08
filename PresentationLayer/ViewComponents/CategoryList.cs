using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
	public class CategoryList: ViewComponent
	{
		CategoryManager manager = new(new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var categories = manager.GetCategoriesWithItsArticles(); 
			return View(categories);
		}

	}
}
