using Microsoft.Extensions.Logging;
using AutoMapper;

namespace ECommerce.Services.Base
{
    public abstract class BaseService
    {
        protected ILogger _logger;
        protected IMapper _mapper;

        public BaseService(ILogger logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
    }
}
