using ECommerce.DataAccess;
using ECommerce.Models;
using ECommerce.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repositories.Authors
{
    public class AuthorRepository : BaseCrudRepository<Author>, IAuthorRepository
    {
        protected override DbSet<Author> DbEntitiesSet { get; }
        public AuthorRepository(ECommerceDbContext context)
            : base(context)
        {
        }
    }
}
