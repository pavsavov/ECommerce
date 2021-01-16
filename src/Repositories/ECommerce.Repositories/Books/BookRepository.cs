using ECommerce.DataAccess;
using ECommerce.Models;
using ECommerce.Repositories.Books;
using ECommerce.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories
{
    public class BookRepository : BaseCrudRepository<Book>, IBookRepository
    {
        protected override DbSet<Book> DbEntity { get; }

        public BookRepository(ECommerceDbContext context)
            : base(context)
        {
        }

        public IQueryable<Book> FilteredBooks(Expression<Func<Book, bool>> expression)
        {
            return DbEntity.Where(expression);
        }
    }
}
