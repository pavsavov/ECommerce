﻿using ECommerce.Models.BaseModel;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public class Author : BaseDbModel
    {
        public string AuthorName { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
