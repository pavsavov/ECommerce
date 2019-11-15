using ECommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.DataAccess
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext()
        {
        }

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne<Author>(au => au.Author);

            modelBuilder.Entity<Author>()
                .HasMany<Book>(a => a.Books)
                .WithOne(a => a.Author);

            modelBuilder.Entity<Genre>()
                .HasMany<Book>(b => b.Books)
                .WithOne(g => g.Genre);
        }
    }
}
