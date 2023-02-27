using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreBPB
{
    public class SystemContext : DbContext
    {
        public SystemContext() : base()
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseName = "EntityFrameworkCoreBook";
            string conn = $"Server=LAPTOP-2LI3826T\\SQLEXPRESS;Initial Catalog={databaseName};Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);

            base.OnConfiguring(optionsBuilder);
        }
    }
}


