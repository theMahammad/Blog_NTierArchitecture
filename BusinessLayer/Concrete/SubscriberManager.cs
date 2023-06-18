using BusinessLayer.Abstract;
using DataAccessLayer.Exceptions;
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
	public class SubscriberManager : ISubsriberService
	{
		ISubscriberDal subscriberDal;
		public SubscriberManager(ISubscriberDal subscriberDal)
		{
			this.subscriberDal = subscriberDal;
		}

		

		public void Delete(Subscriber t)
		{
			subscriberDal.Delete(t);
		}

		public List<Subscriber> GetAll(Expression<Func<Subscriber, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public Subscriber GetByCondition(Expression<Func<Subscriber, bool>> filter)
		{
			return subscriberDal.GetByCondition(filter);
		}

		public Subscriber GetById(int id)
		{
			return GetByCondition(x=> x.Id == id);
		}

		public void Insert(Subscriber t)
		{
			if (subscriberDal.ContainsSubsciber(t))
			{
				throw new AlreadySubscriberException();
			}
			else
			{
				subscriberDal.Insert(t);
			}
			

		}

		public void Update(Subscriber t)
		{
			throw new NotImplementedException();
		}
	}
}
