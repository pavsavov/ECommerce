using ECommerce.Models.BaseModel;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public class Publisher : BaseDbModel
    {
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
