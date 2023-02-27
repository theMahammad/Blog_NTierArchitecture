using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ArticleManager : IArticleService
	{
		IArticleDal articleDal;
		public ArticleManager(IArticleDal articleDal)
		{
			this.articleDal = articleDal;
		}
		public void Add(Article t)
		{
			articleDal.Insert(t);
		}

		public void Delete(Article t)
		{
			articleDal.Delete(t); 
		}

		public List<Article> GetAll()
		{
			return articleDal.GetAll();
		}

		public Article GetById(int id)
		{
			return articleDal.GetById(id);
		}

		public void Update(Article t)
		{
			articleDal.Update(t);
		}
	}
}
