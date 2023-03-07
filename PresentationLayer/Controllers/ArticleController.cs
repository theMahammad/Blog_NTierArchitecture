using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        ArticleManager manager = new (new EfArticleRepository());


        public IActionResult Index()
        {
            var articles = manager.GetAll(x=>x.IsDeleted==false);
            return View(articles);
        }
        public IActionResult AddArticle()
        {
                       
            return RedirectToAction("Index");
        }
              
        
        public IActionResult ArticleDetails([FromRoute]int id,[FromQuery]string _){

            var selectedArticle = manager.GetByIdWithAllRelatedElements(id);
            
            if(selectedArticle != null)
            {
                return View(selectedArticle);
            }
            else
            {
                return View("Error",new ErrorViewModel() { RequestId="404"});
            }
           
        }
    }
}

