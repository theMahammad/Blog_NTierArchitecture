using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DataAccessLayer.EntityFramework
{
	public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
	{
		HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
		const int keySize = 64;
		const int iterations = 350000;
		string HashPassword (string password, out byte[] salt)
		{
			salt = RandomNumberGenerator.GetBytes(keySize);
			var hash = Rfc2898DeriveBytes.Pbkdf2(
				Encoding.UTF8.GetBytes(password),
				salt,
				iterations,
				hashAlgorithm,
				keySize
				);
			var test = hash;
			return Convert.ToHexString(test);
		}
		public Writer GetSelectedWriterWithItsArticles(int writerId)
		{
			using (var context = new Context())
			{
			var writers = context.Writers.Include(x=> x.Articles);
				return writers.FirstOrDefault(x=> x.ID==writerId);
			}
		}

		public void WriterAddByHashing(Writer writer)
		{
			writer.Password = HashPassword(writer.Password, out var salt);
			Insert(writer);
		}
	}
}
