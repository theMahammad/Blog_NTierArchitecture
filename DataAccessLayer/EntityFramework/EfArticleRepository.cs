using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfArticleRepository : GenericRepository<Article>, IArticleDal
	{
		public Article ShowSelectedArticle(int id)
		{
			var article = GetById(id);
			article.ClickAmount++;
			context.SaveChanges();
			return article;
		}
	}
}
