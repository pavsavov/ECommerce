using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ECommerce.DataAccess;
using ECommerce.Models.BaseModel;
using ECommerce.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Base
{
    public abstract class BaseCrudRepository<TEntity> : BaseRepository<TEntity>, ICrudRepository<TEntity>
        where TEntity : BaseDbModel
    {
        protected abstract DbSet<TEntity> DbEntitiesSet { get; }

        public BaseCrudRepository(ECommerceDbContext context)
            : base(context)
        {
        }

        public async Task<TEntity> SaveAsync(TEntity entity)
        {
            var hasEntry = await DbEntitiesSet.AnyAsync(x => x.Id == entity.Id);

            if (!hasEntry)
            {
                DbEntitiesSet.Add(entity);
            }
            else
            {
                await EnsureEntityIsAttached(DbEntitiesSet, entity);
            }

            // Context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await EnsureEntityIsAttached(DbEntitiesSet, entity);

            DbEntitiesSet.Remove(entity);

            await Context.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbEntitiesSet;
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await DbEntitiesSet.FindAsync(id);
        }



    }
}

