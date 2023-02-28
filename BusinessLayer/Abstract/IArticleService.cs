using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IArticleService:IGenericService<Article>
	{
		public List<Article> GetAllArticlesWithCategory();
		Article GetArticleByIncreasingClickAmount(int id);
		public List<Article> GetAllArticlesWithAllRelatedElements();
	}
}
