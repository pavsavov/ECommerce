using ECommerce.Models.BaseModel;
using System.Collections.Generic;

namespace ECommerce.Models
{
    public class Book : BaseDbModel
    {
        public string Title { get; set; }

        public string ISBN { get; set; }

        public string EAN { get; set; }

        public Price Price { get; set; }

        public Publisher Publisher { get; set; }

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Author> Authors { get; set; }
    }
}
