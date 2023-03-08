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
		public Article GetByIdIncreasingClickAmount(int id);
        public void IncreaseClickAmount(Article article);
		public List<Article> GetAllArticlesWithCategory();
		public List<Article> GetAllArticlesWithAllRelatedElements();
		public Article GetByIdWithAllRelatedElements(int id);
		public Article GetRecent();
	}
}
