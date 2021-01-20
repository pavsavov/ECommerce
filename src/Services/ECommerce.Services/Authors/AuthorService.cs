using AutoMapper;
using ECommerce.Repositories.Authors;
using ECommerce.Services.Base;
using ECommerce.Services.Models.Author.ServiceModels.Base;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Services.Authors
{
    //global exception handling ..
    public class AuthorService : BaseService, IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository, ILogger logger, IMapper mapper)
            : base(logger, mapper)
        {
            _authorRepository = authorRepository;
        }

        public Task<bool> DeleteAsync(BaseAuthorServiceModel deleteObject)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BaseAuthorServiceModel> FilterSet(Expression<Func<BaseAuthorServiceModel, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BaseAuthorServiceModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BaseAuthorServiceModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseAuthorServiceModel> SaveAsync(BaseAuthorServiceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
