using BookingService.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Server.Data
{
    public class SystemContext: DbContext
    {
        public SystemContext(DbContextOptions options) : base(options)
        {


        }

        public SystemContext() : base()
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Port> Port { get; set; }
        public DbSet<ContainerType> ContainerType { get; set; }
        public DbSet<Booking> Booking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=LAPTOP-2LI3826T\\SQLEXPRESS;Initial Catalog=BookingService;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(conn);


            base.OnConfiguring(optionsBuilder);
        }
    }
}



