using AutoMapper;
using ECommerce.Services.Books;
using ECommerce.Services.Models;
using ECommerce.Web.Models.BookViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.Web.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("/api/book/")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllAsync();

            //books = new List<BookServiceModel>()
            //{
            //    new BookServiceModel(){ISBN = "asd"}
            //};

            if (books is null)
            {
                return Ok("There are no books to list");
            }

            return Ok(  books); 
        }

        [HttpPost("create")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookViewModel viewModel)
        {
            if (viewModel is null)
            {
                return BadRequest("Fill all needed data");
            }

            var serviceModels = _mapper.Map<BookServiceModel>(viewModel);

            await _bookService.SaveAsync(serviceModels);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(BookViewModel viewModel)
        {
            if (viewModel is null)
            {
                return BadRequest("Fill all needed data");
            }

            var serviceModel = _mapper.Map<BookServiceModel>(viewModel);

            var book = _bookService.GetByIdAsync(viewModel.ISBN)
        }
    }
}
