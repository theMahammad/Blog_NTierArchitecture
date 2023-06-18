using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Exceptions
{
	public class AlreadySubscriberException : Exception
	{
		public AlreadySubscriberException(string? message= "This person has already been our subscriber") : base(message)
		{
			
		}
	}
}
