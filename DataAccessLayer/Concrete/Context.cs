using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
            modelBuilder.Entity<Writer>().Property(x => x.About).IsRequired(false) ;
            modelBuilder.Entity<Writer>().Property(x => x.Image).IsRequired(false);
            modelBuilder.Entity<Subscriber>().Property(x => x.Status).HasDefaultValue(true);
            modelBuilder.Entity<Subscriber>().Property(x => x.SubscribingBeginDate).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Subscriber>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<Comment>().Property(x => x.Status).HasDefaultValue(true);
            modelBuilder.Entity<About>().Property(x => x.Status).HasDefaultValue(true);
			modelBuilder.Entity<Comment>().Property(x => x.Date).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Contact>().Property(x => x.Date).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Contact>().Property(x => x.IsReaded).HasDefaultValue(false);
            




		}
		public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
       
        
    }
}
