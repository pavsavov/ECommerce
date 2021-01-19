using AutoMapper;
using ECommerce.Services.Base;
using ECommerce.Services.Models.Author.ServiceModels;
using Microsoft.Extensions.Logging;

namespace ECommerce.Services.Authors
{
    //global exception handling ..
    public class AuthorService : BaseCrudService<AuthorServiceModel>
    { 
        public AuthorService(ILogger logger, IMapper mapper)
            : base(mapper, logger)
        {
        }
    }
}
