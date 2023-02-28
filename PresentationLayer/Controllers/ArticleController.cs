﻿using BusinessLayer.Concrete;
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
            var articles = manager.GetAllArticlesWithAllRelatedElements();
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
       
        public IActionResult ArticleDetails(int id){

            var selectedArticle = manager.GetArticleByIncreasingClickAmount(id);
            

            return View(selectedArticle);
        }
    }
}

