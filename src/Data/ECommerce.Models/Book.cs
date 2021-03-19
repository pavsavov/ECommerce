using ECommerce.Models.BaseModel;
using System;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public class Book : BaseDbModel
    {
        public string Title { get; set; }

        public string ISBN { get; set; }

        public string EAN { get; set; }

        public int NumberOfPages { get; set; }

        public DateTime YearPublished { get; set; }

        public Price Price { get; set; }

        public Publisher Publisher { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }

        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<BookAuthor> BookAuthors { get; set; }
    }
}
