using ECommerce.Models.BaseModel;
using System;

namespace ECommerce.Models
{
    public class Book : BaseDbModel
    {
        public string Title { get; set; }

        public Author Author { get; set; }

        public string ISBN { get; set; }

        public Genre Genre { get; set; }
    }
}
