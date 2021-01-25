using ECommerce.Services.AutoMapper;
using ECommerce.Services.Models.Book.ServiceModels;

namespace ECommerce.Web.Models.BookViewModels
{
    public class BookViewModel : IMapTo<BookServiceModel>, IMapFrom<BookServiceModel>
    {
        public string Test { get; set; }
    }
}
