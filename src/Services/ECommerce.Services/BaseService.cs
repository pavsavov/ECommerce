using ECommerce.DataAccess;
using ECommerce.Models.BaseModel;
using ECommerce.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public abstract class BaseService<TEntity> : ICRUDService<TEntity>
        where TEntity : BaseDbModel
    {
        private readonly ECommerceDbContext _context;
        public BaseService(ECommerceDbContext context)
        {
            _context = context;
        }
        public virtual Task<TEntity> Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> Update(TEntity Entity)
        {
            throw new NotImplementedException();
        }
    }
}
