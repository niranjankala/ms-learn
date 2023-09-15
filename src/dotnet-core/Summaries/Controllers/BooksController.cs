using Microsoft.AspNetCore.Mvc;
using Summaries.Data.Models;
using Summaries.Data.Services;

namespace Summaries.Controllers
{
    [Route("api/[controller]")]
    public class BooksController:Controller
    {
        private IBookService _service;
        private readonly ILogger<BooksController> _logger;
        public BooksController(ILogger<BooksController> logger, IBookService service)
        {
            _service = service;
            _logger = logger;
        }

        //Create/Add a new book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody]Book book)
        {
            _service.AddBook(book);
            return Ok("Added");
        }

        //Read all books
        [HttpGet("[action]")]
        public IActionResult GetBooks()
        {
            var allBooks = _service.GetAllBooks();
            return Ok(allBooks);
        }

        //Update an existing book
        [HttpPut("UpdateBook/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]Book book)
        {
            _service.UpdateBook(id, book);
            return Ok(book);
        }

        //Delete a book
        [HttpDelete("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            _service.DeleteBook(id);
            return Ok();
        }

        //Get a single book by id
        [HttpGet("SingleBook/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _service.GetBookById(id);
            return Ok(book);
        }
    }
}