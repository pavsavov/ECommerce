using AutoMapper;
using ECommerce.Repositories.Authors;
using ECommerce.Services.Base;
using ECommerce.Services.Models.Author.ServiceModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Services.Authors
{
    public class AuthorService : BaseService, IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository, /*ILogger logger,*/ IMapper mapper)
            : base(/*logger,*/ mapper)
        {
            _authorRepository = authorRepository;
        }

        public Task<bool> DeleteAsync(AuthorServiceModel deleteObject)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AuthorServiceModel>> FilterByAsync(Expression<Func<AuthorServiceModel, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AuthorServiceModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AuthorServiceModel> GetByIdAsync(Guid? id)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorServiceModel> SaveAsync(AuthorServiceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
