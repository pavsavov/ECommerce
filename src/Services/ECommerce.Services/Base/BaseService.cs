﻿using Microsoft.Extensions.Logging;
using AutoMapper;
using ECommerce.Services.Contracts;

namespace ECommerce.Services.Base
{
    public abstract class BaseService : IService
    {
        protected readonly ILogger _logger;
        protected readonly IMapper _mapper;

        public BaseService(ILogger logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }
    }
}
