using System;

namespace ECommerce.Models.BaseModel
{
    public abstract class BaseDbModel
    {
        /// <summary>
        /// Every time a new instance is created, a default valued Guid Id will be assgined
        /// </summary>
        protected BaseDbModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
