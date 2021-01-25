using AutoMapper;
using ECommerce.Services.Books;
using ECommerce.Services.Models.Book.ServiceModels;
using ECommerce.Web.Models.BookViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.Web.Controllers
{
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpGet("book/grid")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllAsync();

            if (books is null)
            {
                return Ok("There are no books to list");
            }

            return Ok(books);
        }


        [HttpPost("book/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookViewModel viewModel)
        {
            if (viewModel is null)
            {
                return BadRequest("Fill all needed data");
            }

            var serviceModels = _mapper.Map<BookServiceModel>(viewModel);

            var newBook = await _bookService.SaveAsync(serviceModels);

            var mappedViewModel = _mapper.Map<BookViewModel>(newBook);

            return Ok(mappedViewModel);
        }
    }
}
