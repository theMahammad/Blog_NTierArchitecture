using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ArticleManager : IArticleService
	{
		IArticleDal articleDal;
		// Sabah EF əvəzinə başqa ORM işlədə bilərik deyə EFRepo ilə yox, birbaşa I__Dal ilə çağırdıq.
		public ArticleManager(IArticleDal articleDal)
		{
			this.articleDal = articleDal;
		}
		public void Insert(Article t)
		{
			t.Content = t.Content.Trim();
			articleDal.Insert(t);
		}

		public void Delete(Article t)
		{
			articleDal.Delete(t); 
		}

		

		public Article GetById(int id)
		{
			return articleDal.GetById(id);
		}

		public Article GetByIdIncreasingClickAmount(int id)
		{
			return articleDal.GetByIdIncreasingClickAmount(id);
		}

		public void Update(Article t)
		{
			articleDal.Update(t);
		}

		public List<Article> GetAllArticlesWithCategory()
		{
			return articleDal.GetAllArticlesWithCategory();
		}

		public List<Article> GetAllArticlesWithAllRelatedElements()
		{
			return articleDal.GetAllArticlesWithAllRelatedElements();
		}

        public Article GetByIdWithAllRelatedElements(int id)
        {
			if(id!=0)
			{
                return articleDal.GetByIdWithAllRelatedElements(id);
			}
			else
			{
				return null;
			}
			
        }

		public List<Article> GetAll(Expression<Func<Article, bool>> filter = null)
		{
			return articleDal.GetAll(filter);
		}

		public Article GetRecent()
		{
			return articleDal.GetRecent();
		}
	}
}
