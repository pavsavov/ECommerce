using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using eCommerce.Repository.Contracts;
using ECommerce.DataAccess;
using ECommerce.Models.BaseModel;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Repository
{
    public abstract class BaseRepository<TEntity> : ICrudRepository<TEntity>
        where TEntity : BaseDbModel
    {
        private readonly ECommerceDbContext _context;

        //Will get back to this. Not sure if I will need to have the DbSet
        // protected abstract DbSet<TEntity> Entities { get; }

        public BaseRepository(ECommerceDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            //_dbset = _context.Set<TEntity>();

        }

   //TODO: TEST !!
        public async virtual Task<TEntity> Save(TEntity entity)
        {
            _context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return await EnsureIsDeleted(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllByAny(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        private async Task<bool> EnsureIsDeleted(TEntity entity)
        {
            return await GetById(entity.Id) != default;
        }
    }
}

