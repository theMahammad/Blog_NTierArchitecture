﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
	{
		public Writer GetSelectedWriterWithItsArticles(int writerId)
		{
			using (var context = new Context())
			{
			var writers = context.Writers.Include(x=> x.Articles);
				return writers.FirstOrDefault(x=> x.ID==writerId);
			}
		}
	}
}
