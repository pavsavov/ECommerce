using ECommerce.DataAccess;
using ECommerce.Models.BaseModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Base
{
    /// <summary>
    /// The need for this class is based on the need to chec
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class BaseRepository<TEntity> : IBaseRepository
        where TEntity : BaseDbModel
    {
        private readonly ECommerceDbContext _context;

        protected ECommerceDbContext Context { get => _context; }

        public BaseRepository(ECommerceDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected async Task EnsureEntityIsAttached(DbSet<TEntity> dbSet, TEntity entity)
        {
            await Task.Run(() =>
            {
                if (dbSet is null)
                {
                    throw new ArgumentNullException(nameof(dbSet), "DbSet collection is null");
                }

                if (entity is null)
                {
                    throw new ArgumentNullException(nameof(entity), "Provided entity of type TEntity is null");
                }

                var entry = _context.Entry<TEntity>(entity);

                if (entry.State == EntityState.Detached)
                {
                    dbSet.Attach(entity);
                }

                entry.State = EntityState.Modified;
            });
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
