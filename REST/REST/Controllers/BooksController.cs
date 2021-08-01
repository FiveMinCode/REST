using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksController()
        {
            
        }
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(new List<Book>() { new Book()
            {
                Id = 1,
                Genre = "Computers",
                ReleaseDate = DateTime.Now.AddDays(-1500)
            } });
        }
        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            return Ok(new Book()
            {
                Id = 1,
                Genre = "Computers",
                ReleaseDate = DateTime.Now.AddDays(-1500)
            });
        }
        [HttpPost]
        public IActionResult SaveBook(Book book)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            return Ok();
        }
    }
}
