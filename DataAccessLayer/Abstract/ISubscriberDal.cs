﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface ISubscriberDal:IGenericDal<Subscriber>
	{
		public bool ContainsSubsciber(Subscriber subscriber);
		public Subscriber GetByCondition(Expression<Func<Subscriber, bool>> filter);
	}
}
