using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IArticleDal:IGenericDal<Article>
	{
		public Article GetArticleByIncreasingClickAmount(int id);
		public List<Article> GetAllArticlesWithCategory();
		public List<Article> GetAllArticlesWithAllRelatedElements();
	}
}
