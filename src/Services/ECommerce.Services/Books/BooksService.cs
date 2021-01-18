using AutoMapper;
using ECommerce.Models;
using ECommerce.Services.Base;
using Microsoft.Extensions.Logging;


namespace ECommerce.Services.Books
{
    public class BooksService : BaseCrudService<Book>
    {
        public BooksService(ILogger logger,IMapper mapper)
            : base(mapper, logger)
        {
           
        }
    }
}
