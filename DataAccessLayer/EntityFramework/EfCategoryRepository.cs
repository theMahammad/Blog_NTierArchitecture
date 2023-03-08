﻿using DataAccessLayer.Abstract;
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
    public class EfCategoryRepository:GenericRepository<Category>,ICategoryDal
    {
		public List<Category> GetCategoriesWithItsArticles()
		{

			var categories = context.Categories.Include(x=> x.Articles).ToList();
			return categories;
		}
	}
}
