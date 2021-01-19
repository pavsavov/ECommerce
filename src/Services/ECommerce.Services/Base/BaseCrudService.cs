using AutoMapper;
using ECommerce.Services.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Services.Base
{
    public abstract class BaseCrudService<T> : BaseService, IBaseCrudService<T>
        where T : IServiceModel
    {
        public BaseCrudService(IMapper mapper, ILogger logger)
            : base(logger, mapper)
        {

        }

        public Task DeleteAsync(T id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FilterSet(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
