using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Models.BaseModel
{
    public class BaseDbModel
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
