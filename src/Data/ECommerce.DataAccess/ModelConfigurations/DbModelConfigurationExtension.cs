using ECommerce.InfrastructureCommon;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ECommerce.DataAccess.ModelConfigurations
{
    public static class DbModelConfigurationExtension
    {
        public static ModelBuilder DbConfigurationRegitrator(this ModelBuilder builder)
        {
            builder.BookConfiguration();


            return builder;
        }

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
                j => j.HasKey(fk => new { fk.BookId, fk.AuthorId })
                );

            return builder;
        }
    }
}
