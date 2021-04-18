using Bookstore.Entities;
using Bookstore.Entities.API.Models;
using Bookstore.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.API.API.Controllers
{
    [Route("api/BooksAPI")]
    [ApiController]
    public class BooksAPIController : ControllerBase
    {
        private readonly IBookService _bookService;
        private ILogger<BooksAPIController> _logger;

        public BooksAPIController(IBookService bookService, ILogger<BooksAPIController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpGet("BooksData")]
        public IEnumerable<Book> GetBooksFullData()
        {
            var books = _bookService.GetAllBooks();
            return books.AsEnumerable();
        }
        [HttpGet("Books")]
        public IEnumerable<BooksApiDTO> GetBooks()
        {
            var bookList = new List<BooksApiDTO>();
            var books = _bookService.GetAllBooks();

            foreach (var book in books)
            {
                var bookDTO = new BooksApiDTO()
                {
                    Title = book.Title,
                    Author = book.AuthorName,
                    Publisher = book.PublisherName
                };
                bookList.Add(bookDTO);
            }
            return bookList.AsEnumerable();
        }

        [HttpGet("BooksDataV2")]
        public IEnumerable<Book> GetBooksFullDataV2()
        {
            var books = _bookService.GetAllBooksWithFullRelationalData();
            return books.AsEnumerable();
        }

        [HttpGet("GetBook")]

        public ActionResult<Book> GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost("AddBook")]

        public ActionResult<Book> AddBook(Book book)
        {
            _bookService.Add(book);
            return CreatedAtAction("AddBook", new { id = book.Id, book });
        }

        [HttpGet("BookTest1")]
        public ActionResult<Book> BookTest(int id, string testString)
        {
            if (testString == "CodeAcademy")
            {
                _logger.LogInformation("Get request from bookTest with params id: {0} and string: {1} ", id, testString);

            }
            else
            {
                _logger.LogError("Bad request from bookTest with params id: {0} and string: {1} ", id, testString);
                return BadRequest();
            }
            return Ok();
        }
    }
}
