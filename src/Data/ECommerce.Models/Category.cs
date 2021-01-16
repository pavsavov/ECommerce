using ECommerce.Models.BaseModel;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public class Category : BaseDbModel
    {
        public string CategoryTitle { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
