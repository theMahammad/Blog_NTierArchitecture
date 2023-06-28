using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class ContactManager : IContactService
	{
		IContactDal contactDal;

		public ContactManager(IContactDal contactDal)
		{
			this.contactDal = contactDal;
		}
		public void Delete(Contact t)
		{
			throw new NotImplementedException();
		}

		public List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public Contact GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Insert(Contact t)
		{
			contactDal.Insert(t);
		}

		public void Update(Contact t)
		{
			throw new NotImplementedException();
		}
	}
}
