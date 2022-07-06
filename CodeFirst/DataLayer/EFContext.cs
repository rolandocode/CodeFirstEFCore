using Microsoft.EntityFrameworkCore;

namespace CodeFirst.DataLayer
{
    public class EFContext : DbContext
    {

        private const string connectionString = "Server=LAPTOP-OQISIOPD\\SQLEXPRESS;Database=EFCoreMigration;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
