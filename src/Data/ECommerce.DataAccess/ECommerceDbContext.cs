using Microsoft.EntityFrameworkCore;


namespace ECommerce.DataAccess
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Book>{get;set;}
    }
}
