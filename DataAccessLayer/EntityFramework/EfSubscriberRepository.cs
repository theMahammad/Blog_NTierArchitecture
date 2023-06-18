using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfSubscriberRepository:GenericRepository<Subscriber>,ISubscriberDal
	{
		public bool ContainsSubsciber(Subscriber subscriber)
		{
			var data = 	context.Subscribers.FirstOrDefault(x => x.Email == subscriber.Email);
				if(data == null)
				{
					return false;
				}
				else
				{
					return true;
				}
		}
		public new void Delete(Subscriber subscriber)
		{
			
			subscriber.Status = false;
			subscriber.SubscribingCancelDate = DateTime.Now;
			Update(subscriber);
		}

		public Subscriber GetByCondition(Expression<Func<Subscriber, bool>> filter)
		{
			return context.Subscribers.FirstOrDefault(filter);
		}
	}
}
