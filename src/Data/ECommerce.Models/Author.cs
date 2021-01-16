using ECommerce.Models.BaseModel;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public class Author : BaseDbModel
    {
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }

    }
}
