using BooksApi.Data;
using BooksApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{

    [Route("api/book/")]
    [ApiController]
    public class BookController : Controller
    {
        [HttpGet("getAllBooks")]
        public List<Book> GetAllBooks()
        {
            Console.WriteLine("Server is Live");
            return BooksData.booksData;
        }

        [HttpGet("getBookById/{id}")]
        public IActionResult GetBookById(int id)
        {
            return Ok(BooksData.booksData.Find(book => book.id == id));
        }

        [HttpPost("addBook")]
        public IActionResult PostOneBook([FromForm] PostBookRequestModel bookRequestModel)
        {
            if (string.IsNullOrWhiteSpace(bookRequestModel.name) ||
                string.IsNullOrWhiteSpace(bookRequestModel.author) ||
                string.IsNullOrWhiteSpace(bookRequestModel.description))
            {
                return BadRequest(
                    new
                    {
                        status = "error",
                        message = "Please provide all the details"
                    }
                );
            }
            else
            {
                Book book = new Book()
                {
                    id = BooksData.booksData.Count + 1,
                    name = bookRequestModel.name,
                    author = bookRequestModel.author,
                    description = bookRequestModel.description
                };
                BooksData.booksData.Add(book);
                return Ok(
                    new
                    {
                        status = "success",
                        message = "Book added successfully"
                    }
                );
            }
        }

        [HttpDelete("deleteBookById/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            Book book = BooksData.booksData.Find(book => book.id == id);
            if (book == null)
            {
                return BadRequest(
                    new
                    {
                        status = "error",
                        message = "Book not found"
                    }
                );
            }
            else
            {
                BooksData.booksData.Remove(book);
                return Ok(
                    new
                    {
                        status = "success",
                        message = "Book deleted successfully"
                    }
                );
            }
        }

        [HttpPut("updateBookById/{id}")]
        public IActionResult UpdateBookById(int id, [FromForm] UpdateBookRequestModel updateBookRequestModel)
        {
            Book book = BooksData.booksData.Find(book => book.id == id);
            if (book == null)
            {
                return BadRequest(
                    new
                    {
                        status = "error",
                        message = "Book not found"
                    }
                );
            }
            else
            {

                if (!string.IsNullOrWhiteSpace(updateBookRequestModel.name))
                {
                    book.name = updateBookRequestModel.name;
                }
                if (!string.IsNullOrWhiteSpace(updateBookRequestModel.author))
                {
                    book.author = updateBookRequestModel.author;
                }
                if (!string.IsNullOrWhiteSpace(updateBookRequestModel.description))
                {
                    book.description = updateBookRequestModel.description;
                }
                return Ok(
                    new
                    {
                        status = "success",
                        message = "Book updated successfully"
                    }
                );
            }
        }
    }
}
