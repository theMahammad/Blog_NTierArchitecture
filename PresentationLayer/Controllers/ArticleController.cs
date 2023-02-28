using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        ArticleManager manager = new (new EfArticleRepository());
        public string GetFirstXWord(string content,int wordAmount)
        {
            string resultText = "";
            int count=1;
           for(int i=0; i<content.Length; i++)
            {
                
                if (content[i]==' ')
                {
                    if (count == wordAmount)
                    {
                        resultText = content.Substring(0, i);
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
               
                
            }
			if (count == 1)
			{
				return content;
			}
			else
			{
				return resultText;
			}



		}

        public IActionResult Index()
        {
            var articles = manager.GetAllArticlesWithAllRelatedElements();
            //For displaying only three word
            articles.ForEach(x => x.Content = GetFirstXWord(x.Content, 3));
            return View(articles);
        }
        public IActionResult AddArticle()
        {
            Article article = new()
            {
                Title = "Test",
                Content = "Content Content Content Content Content",
                CreateDate = DateTime.Now,
                Image = "image.jpg",
                ThumbNailImage = "thumbnail.jpg",
                IsDeleted= false,
                WriterId = 2,
                CategoryID = 1
                
            };
            manager.Add(article);            
            return RedirectToAction("Index");
        }
        public IActionResult GetArticle(int id){

            var selectedArticle = manager.GetArticleByIncreasingClickAmount(id);
            selectedArticle.ClickAmount++;

            return RedirectToAction("Index");
        }
    }
}

