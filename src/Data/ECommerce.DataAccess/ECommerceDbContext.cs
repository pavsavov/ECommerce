using ECommerce.DataAccess.ModelConfigurations;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.DataAccess
{
    /// <summary>
    ///https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/domain-events-design-implementation
    /// https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-implementation-entity-framework-core
    /// </summary>
    public class ECommerceDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }

        public DbSet<BookCategory> BookCategories { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.DbConfigurationRegitrator();
        }
    }
}
