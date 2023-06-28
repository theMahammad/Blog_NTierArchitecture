﻿using BusinessLayer.Abstract;
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
	public class AboutManager:IAboutService
	{
		IAboutDal aboutDal;
		public AboutManager(IAboutDal aboutDal)
		{
			this.aboutDal = aboutDal;
		}

		public void Delete(About t)
		{
			throw new NotImplementedException();
		}

		public List<About> GetAll()
		{
			return aboutDal.GetAll();
		}

		public List<About> GetAll(Expression<Func<About, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public About GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Insert(About t)
		{
			throw new NotImplementedException();
		}

		public void Update(About t)
		{
			throw new NotImplementedException();
		}
	}
}
