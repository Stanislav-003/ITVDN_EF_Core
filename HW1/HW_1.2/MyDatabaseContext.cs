using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_1._1;
using HW_2._1;

namespace HW_1._2
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<Product> products { get; set; } = null!;
        public DbSet<Error> errors { get; set; }

        public MyDatabaseContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Stanislav003\SQLEXPRESS;Database=DbOfProducts;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Error>()
                .HasKey(e => e.AlterId);

            modelBuilder.Ignore<Error>();
            //modelBuilder.Entity<Error>().HasNoKey();
        }
    }
}
