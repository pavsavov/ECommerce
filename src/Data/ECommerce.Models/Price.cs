using System.Collections.Generic;

namespace ECommerce.Models
{
    public class Price
    {
        public decimal PriceTag { get; set; }

        public string Currency { get; set; }

        public IEnumerable<Book> Book { get; set; }
    }
}
