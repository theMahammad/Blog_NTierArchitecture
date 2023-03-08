using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{

	public class EfArticleRepository : GenericRepository<Article>, IArticleDal
	{
		public List<Article> GetAllArticlesWithAllRelatedElements()
		{
			
			using (var context = new Context())
			{
				return context.Articles
					.Include(x => x.Category)
					.Include(x=> x.Writer)
					.Include(x=> x.Comments)
					.ToList();

			}
		}

		public List<Article> GetAllArticlesWithCategory()
		{
			using(var context = new Context())
			{
				return context.Articles.Include(x => x.Category).ToList();

			}
		}

		public Article GetByIdIncreasingClickAmount(int id)
		{
			var article = GetById(id);
			IncreaseClickAmount(article);
            return article;
		}

        public Article GetByIdWithAllRelatedElements(int id)
        {	
			var selectedArticle = GetAllArticlesWithAllRelatedElements().Find(x=>x.ID == id);
			IncreaseClickAmount(selectedArticle);
            return selectedArticle;
        }

		public Article GetRecent()
		{
			return context.Articles.OrderBy(x=> x.CreateDate).Last();
		}

		public void IncreaseClickAmount(Article article)
        {
            article.ClickAmount++;
            Update(article);
        }
    }
}
