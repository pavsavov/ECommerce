using AutoMapper;
using ECommerce.Repositories.Books;
using ECommerce.Services.Base;
using ECommerce.Services.Models.Book.ServiceModels;
using ECommerce.Services.Models.Book.ServiceModels.Base;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ECommerce.Services.Books
{
    public class BookService : BaseService, IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(
            IBookRepository bookRepository,
            ILogger logger,
            IMapper mapper
            )
            : base(logger, mapper)
        {
            _bookRepository = bookRepository;
        }

        public Task<bool> DeleteAsync(BaseBookServiceModel deleteObject)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BaseBookServiceModel> FilterSet(Expression<Func<BaseBookServiceModel, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BaseBookServiceModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BaseBookServiceModel> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseBookServiceModel> SaveAsync(BaseBookServiceModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
