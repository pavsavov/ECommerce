using ECommerce.DataAccess;
using ECommerce.Models.BaseModel;
using ECommerce.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ECommerce.Services.Base
{
    public abstract class BaseService
    {
        protected ILogger _logger;
        //protected IMapper _mapper;

        public BaseService(ILogger logger)
        {
            _logger = logger;
        }
    }
}
