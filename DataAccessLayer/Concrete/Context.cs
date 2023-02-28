using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = "server = MAHAMMAD;" +
                " database = MyBlogDb;" +
                " integrated security = SSPI;" +
                " TrustServerCertificate = true;";
            optionsBuilder.UseSqlServer(conString);
            
            
           
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Article>().Property(x => x.CreateDate).HasColumnType("datetime");
            modelBuilder.Entity<Article>().Property(x => x.ClickAmount).HasDefaultValue(0);
		}
		public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }

        
    }
}
