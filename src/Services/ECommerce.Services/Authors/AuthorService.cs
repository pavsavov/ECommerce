using AutoMapper;
using ECommerce.Models;
using ECommerce.Services.Base;
using Microsoft.Extensions.Logging;

namespace ECommerce.Services.Authors
{
    public class AuthorService : BaseCrudService<Author>
    {
        public AuthorService(ILogger logger, IMapper mapper)
            : base(mapper, logger)
        {
        }
    }
}
