using ECommerce.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Models
{
    public class Author : BaseDbModel
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
