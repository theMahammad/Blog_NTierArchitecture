using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Test2
{
	internal class Program
	{
		public string A(int x)
		{
			return x.ToString() + "Aue";
		}
		public string B(int x)
		{
			return x.ToString() + "Salam";
		}
		

		public Func<int, string> func;
		

		public Expression<Func<int, string>> exp;
		static void Main(string[] args)
		{
			Program program = new Program();
			
			program.func += program.B;
			// program.func.GetInvocationList().ToList().ForEach(x => Console.WriteLine(x.DynamicInvoke(5)));
			var delegateList = program.func.GetInvocationList().ToList();
			foreach(var item in delegateList)
			{
				
			}
			
		}
	}
}