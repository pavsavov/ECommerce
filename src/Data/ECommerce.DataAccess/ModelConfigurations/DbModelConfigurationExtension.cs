using ECommerce.Common;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.ModelConfigurations
{
    /// <summary>
    /// reference : https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=fluent-api%2Cfluent-api-composite-key%2Ccomposite-key
    /// </summary>
    public static class DbModelConfigurationExtension
    {
        #region Register defined database entities' configurations
        public static ModelBuilder DbConfigurationRegitrator(this ModelBuilder builder)
        {
            builder.BookConfiguration();
            builder.AuthorConfiguration();
            builder.BookAuthorConfiguration();
            builder.CategoryConfiguration();
            builder.PriceConfiguration();
            builder.PublisherConfiguration();

            return builder;
        }
        #endregion

        #region Define database entities' Fluent API configurations
        private static ModelBuilder BookConfiguration(this ModelBuilder builder)
        {
            builder.Entity<Book>()
                .ToTable(ECommerceConstants.BOOKS_TABLE)
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .UsingEntity<BookAuthor>(
                 j => j
                     .HasOne(ba => ba.Author)
                     .WithMany(a => a.BookAuthors)
                     .HasForeignKey(ba => ba.AuthorId),
                 j => j
                     .HasOne(ba => ba.Book)
                     .WithMany(b => b.BookAuthors)
                     .HasForeignKey(a => a.BookId),
                j => j
                     .HasKey(fk => new { fk.BookId, fk.AuthorId })
                );

            builder.Entity<Book>()
                .HasOne(b => b.Price)
                .WithMany(p => p.Books);

            builder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books);

            return builder;
        }

        private static ModelBuilder AuthorConfiguration(this ModelBuilder builder)
        {
            builder.Entity<Author>()
                   .ToTable(ECommerceConstants.AUTHOR_TABLE);

            return builder;
        }

        private static ModelBuilder BookAuthorConfiguration(this ModelBuilder builder)
        {
            builder.Entity<BookAuthor>()
                    .ToTable(ECommerceConstants.BOOKAUTHOR_TABLE);

            return builder;
        }

        private static ModelBuilder CategoryConfiguration(this ModelBuilder builder)
        {
            builder.Entity<Category>()
                   .ToTable(ECommerceConstants.CATEGORY_TABLE)
                   .HasMany(c => c.Books)
                   .WithMany(b => b.Categories)
                   .UsingEntity<BookCategory>(
                    j => j
                  .HasOne(bc => bc.Book)
                  .WithMany(b => b.BookCategories)
                  .HasForeignKey(bc => bc.CategoryId),
                    j => j
                  .HasOne(bc => bc.Category)
                  .WithMany(c => c.BookCategories)
                  .HasForeignKey(bc => bc.BookId),
                   j => j
                       .HasKey(fk => new { fk.BookId, fk.CategoryId })
                  );

            return builder;

        }

        private static ModelBuilder PriceConfiguration(this ModelBuilder builder)
        {
            builder.Entity<Price>()
                   .ToTable(ECommerceConstants.PRICE_TABLE);

            return builder;
        }

        private static ModelBuilder PublisherConfiguration(this ModelBuilder builder)
        {
            builder.Entity<Publisher>()
                .ToTable(ECommerceConstants.PUBLISHER_TABLE);

            return builder;
        }
       
       #endregion
    }
}
