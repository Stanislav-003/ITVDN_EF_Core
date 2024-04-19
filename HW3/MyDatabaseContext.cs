using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HW3
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Word> Words { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Stanislav003\SQLEXPRESS;Database=relationshipTables;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
