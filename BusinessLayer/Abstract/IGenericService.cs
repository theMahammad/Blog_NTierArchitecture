using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IGenericService<T> where T: class
	{
		void Insert(T t);
		void Delete(T t);
		void Update(T t);
		List<T> GetAll(Expression<Func<T, bool>> filter = null);
		T GetById(int id);
	}
}
