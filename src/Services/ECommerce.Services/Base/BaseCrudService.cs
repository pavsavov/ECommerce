using AutoMapper;
using ECommerce.Models;
using ECommerce.Models.BaseModel;
using ECommerce.Repositories.Books;
using ECommerce.Repository.Base;
using ECommerce.Services.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Services.Base
{
    public abstract class BaseCrudService<T> : BaseService, ICrudService<T>
        where T : ServiceModel
    {
        private readonly ICrudRepository<Author> _repository;

        public BaseCrudService(ICrudRepository<Author> repository, IMapper mapper, ILogger logger)
            : base(logger, mapper)
        {
            _repository = repository;
        }

        public Task<bool> DeleteAsync(T deleteObject)
        {
            if (deleteObject is null)
            {
                //use logger
                throw new ArgumentNullException(nameof(deleteObject), "The provided object for deletion is null");
            }
            //mapp from serviceModel to dbmodel

            //call repository

            // return true or false
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
