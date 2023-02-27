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
			throw new NotImplementedException();
		}

		public void Delete(Article t)
		{
			throw new NotImplementedException();
		}

		public List<Article> GetAll(Article t)
		{
			throw new NotImplementedException();
		}

		public Article GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Article t)
		{
			throw new NotImplementedException();
		}
	}
}
