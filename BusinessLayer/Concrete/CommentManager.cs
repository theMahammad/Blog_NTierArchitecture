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
	public class CommentManager : ICommentService
	{
		ICommentDal commentDal;
		public CommentManager(ICommentDal commentDal)
		{
			this.commentDal = commentDal;
		}

		public void Insert(Comment t)
		{
			commentDal.Insert(t);
		}

		public void Delete(Comment t)
		{
			throw new NotImplementedException();
		}

		public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
		{
			return commentDal.GetAll(filter);
		}

		public Comment GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(Comment t)
		{
			throw new NotImplementedException();
		}
	}
}
