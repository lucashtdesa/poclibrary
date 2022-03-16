using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using POCLibrary.Models;
using POCLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace POCLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("/search/{term}")]
        public async Task<ActionResult<List<Books>>> GetBooksByTermAsync(string term)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var booklist = await _bookService.FindBooksByTermAsync(term);
                if (booklist == null)
                {
                    return NotFound();
                }
                return Ok(booklist);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
