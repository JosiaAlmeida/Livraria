using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.models;
using biblioteca.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace biblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private BookRepository _service = new BookRepository();
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult Index()
        {
            return Ok(this._service.find());
        }

        [HttpPost()]
        [ProducesResponseType((200), Type = typeof(List<Book>))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        public IActionResult Post([FromBody] Book book)
        {
            if (book == null || book is null) return BadRequest();
            return Ok(this._service.post(book));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}