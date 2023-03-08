using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Subscriber
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public DateTime SubscribingBeginDate { get; set; }
		public DateTime? SubscribingCancelDate { get; set; }
	}
}
