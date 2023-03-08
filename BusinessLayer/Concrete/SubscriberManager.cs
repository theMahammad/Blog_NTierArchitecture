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
	public class SubscriberManager : ISubsriberService
	{
		ISubscriberDal subscriberDal;
		public SubscriberManager(ISubscriberDal subscriberDal)
		{
			this.subscriberDal = subscriberDal;
		}
		public void Delete(Subscriber t)
		{
			throw new NotImplementedException();
		}

		public List<Subscriber> GetAll(Expression<Func<Subscriber, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public Subscriber GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Insert(Subscriber t)
		{
			subscriberDal.Insert(t);
		}

		public void Update(Subscriber t)
		{
			throw new NotImplementedException();
		}
	}
}
