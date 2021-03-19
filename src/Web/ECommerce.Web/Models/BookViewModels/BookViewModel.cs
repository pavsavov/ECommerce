using ECommerce.Services.AutoMapper;
using ECommerce.Services.Models;
using System.Collections.Generic;

namespace ECommerce.Web.Models.BookViewModels
{
    public class BookViewModel : IMapTo<BookServiceModel>, IMapFrom<BookServiceModel>
    {
        public string Title { get; set; }

        public string ISBN { get; set; }
      
        public decimal PriceTag { get; set; }

        public string Currency { get; set; }

        public string EAN { get; set; }

        public int NumberOfPages { get; set; }

        public string YearPublished { get; set; }

        public string PublisherName { get; set; }

        public IEnumerable<string> AuthorsNames { get; set; }

        public IEnumerable<string> Categories { get; set; }
    }
}
