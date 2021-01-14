using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Models.BaseModel
{
    public class BaseDbModel
    {
        /// <summary>
        /// Every time a new instance is created, a default valued Guid Id will be assgined
        /// </summary>
        public BaseDbModel()
        {
            this.Id = default;
        }

        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
