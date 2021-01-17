using ECommerce.DataAccess;
using ECommerce.Models;
using ECommerce.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repositories.Authors
{
    public class AuthorRepositry : BaseCrudRepository<Author>, IAuthorRepository
    {
        protected override DbSet<Author> DbEntitiesSet { get; }
        public AuthorRepositry(ECommerceDbContext context)
            : base(context)
        {
        }
    }
}
