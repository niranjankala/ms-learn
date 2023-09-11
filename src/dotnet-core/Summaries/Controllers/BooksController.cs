using Microsoft.AspNetCore.Mvc;
using Summaries.Data.Services;
using Summaries.Data.Models;

namespace Summaries.Controllers;

[ApiController]
[Route("[controller]")]
public class BooksController : ControllerBase
{
    private IBookService _service;

    public BooksController(IBookService service)
    {
        _service = service;
    }

    //Create/Add a new book
        [HttpPost("AddBook")]
        public IActionResult AddBook([FromBody]Book book)
        {
            _service.AddBook(book);
            return Ok("Added");
        }
}