using AutoMapper;
using ECommerce.Services.Base;
using ECommerce.Services.Models.Book.ServiceModels;
using Microsoft.Extensions.Logging;


namespace ECommerce.Services.Books
{
    public class BooksService : BaseCrudService<BookServiceModel>
    {
        public BooksService(ILogger logger,IMapper mapper)
            : base(mapper, logger)
        {
           
        }
    }
}
