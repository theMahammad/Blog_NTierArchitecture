using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

		public Article GetArticleByIncreasingClickAmount(int id)
		{
			var article = GetById(id);
			article.ClickAmount++;
			context.SaveChanges();
			return article;
		}
	}
}
