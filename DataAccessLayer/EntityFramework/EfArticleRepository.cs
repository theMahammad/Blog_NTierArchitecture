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
	public class EfArticleRepository:GenericRepository<Article>,IArticleDal
	{
	
		public override Article GetById(int id)
		{
			var selectedArticle = context.Articles.Find(id);
			selectedArticle.ClickAmount++;
			context.SaveChanges();
			return selectedArticle;
			
		}
	}
}
