using ECommerce.DataAccess;
using ECommerce.Models;
using ECommerce.Repositories.Books;
using ECommerce.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repositories.Books
{
    public class BookRepository : BaseCrudRepository<Book>, IBookRepository
    {
        protected override DbSet<Book> DbEntitiesSet { get; }
        public BookRepository(ECommerceDbContext context)
            : base(context)
        {
        }
    }
}
