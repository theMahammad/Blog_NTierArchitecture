using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal writerDal;
		public WriterManager(IWriterDal writerDal)
		{
			this.writerDal = writerDal;
		}

		public void Delete(Writer t)
		{
			throw new NotImplementedException();
		}

		public List<Writer> GetAll(Expression<Func<Writer, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public Writer GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Writer GetSelectedWriterWithItsArticles(int writerId)
		{
			return writerDal.GetSelectedWriterWithItsArticles(writerId);
		}

		public void Insert(Writer t)
		{
			t.EmailAdress = t.EmailAdress.Trim();
			t.EmailAdress = t.EmailAdress.ToLower();
			writerDal.Insert(t);
		}

		public void Update(Writer t)
		{
			throw new NotImplementedException();
		}
	}
}
