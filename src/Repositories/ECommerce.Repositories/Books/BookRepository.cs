using ECommerce.DataAccess;
using ECommerce.Models;
using ECommerce.Repositories.Books;
using ECommerce.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Repositories
{
    public class BookRepository : BaseCrudRepository<Book>, IBookRepository
    {
        protected override DbSet<Book> DbEntitiesSet { get; }

        public BookRepository(ECommerceDbContext context)
            : base(context)
        {
        }

        public IQueryable<Book> FilterBooks(Expression<Func<Book, bool>> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate),"No filter expression is provided");
            }

            return GetAll().Where(predicate);
        }

        //protected virtual async Task<bool> EnsureOperation(TEntity entity)
        //{
        //    return await GetByIdAsync(entity.Id) != default;
        //}
    }
}
