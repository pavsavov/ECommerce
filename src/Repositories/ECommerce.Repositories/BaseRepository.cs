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

        public BaseRepository(ECommerceDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async virtual Task<TEntity> SaveAsync(TEntity entity)
        {
            _context.Entry(entity).State = entity.Id == default ? EntityState.Added : EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return await EnsureIsDeletedAsync(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllByAnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().Where(expression).ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        private async Task<bool> EnsureIsDeletedAsync(TEntity entity)
        {
            return await GetByIdAsync(entity.Id) != default;
        }
    }
}

