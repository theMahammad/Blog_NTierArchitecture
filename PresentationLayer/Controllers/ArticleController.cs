using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        ArticleManager manager = new (new EfArticleRepository());
        public IActionResult Index()
        {
            var articles = manager.GetAll();
            return View(articles);
        }
        public IActionResult AddArticle()
        {
            Article article = new()
            {
                Title = "Test",
                Content = "Content Content Content Content Content",
                CreateDate = DateTime.Now.Date,

                CategoryID = 1,
                
            };
            return View("Index");
        }
    }
}

