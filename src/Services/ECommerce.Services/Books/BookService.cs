using AutoMapper;
using ECommerce.Models;
using ECommerce.Repositories.Books;
using ECommerce.Services.Base;
using ECommerce.Services.Extensions;
using ECommerce.Services.Models.Book.ServiceModels;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
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
            ILogger<BaseService> logger,
            IMapper mapper
            )
            : base(logger, mapper)
        {
            _bookRepository = bookRepository;
           
        }

        public async Task<BookServiceModel> SaveAsync(BookServiceModel serviceModel)
        {
            var mappedEntity = _mapper.Map<Book>(serviceModel);

            var book = await _bookRepository.SaveAsync(mappedEntity);

            if (book is null)
            {
                throw new Exception(nameof(book));
            }

            return serviceModel;
        }

        public Task<bool> DeleteAsync(BookServiceModel deleteObject)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookServiceModel>> FilterByAsync(Expression<Func<BookServiceModel, bool>> expression)
        {
            //Using Task.Run everywhere might not be a good practice.Need to read more

            return await Task.Run(() =>
            {
                var mappedExpression = _mapper.Map<Expression<Func<Book, bool>>>(expression);

                var books = _bookRepository.FilterSet(mappedExpression);

                var mappedResult = books.To<BookServiceModel>().AsEnumerable();

                return mappedResult;
            });
        }

        public async Task<IEnumerable<BookServiceModel>> GetAllAsync()
        {
            return await Task.Run(() => _bookRepository
                       .GetAll()
                       .To<BookServiceModel>()
                       .ToList());

        }

        public async Task<BookServiceModel> GetByIdAsync(Guid? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id), "The provided id is null");
            }

            var book = await _bookRepository.GetByIdAsync(id);
            var serviceModel = _mapper.Map<BookServiceModel>(book);

            return serviceModel;
        }
    }
}
