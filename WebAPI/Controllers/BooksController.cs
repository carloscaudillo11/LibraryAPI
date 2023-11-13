using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Models;
using Data.Operaciones;

namespace WebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BooksDAO booksDAO = new BooksDAO();

        [HttpGet("book")]
        public Book getBook(int id)
        {
            return booksDAO.seleccionar(id);
        }

        [HttpGet("books")]
        public List<Book> getBooks()
        {
            return booksDAO.seleccionarTodos();
        }

        [HttpPost("books")]
        public bool CreateBook([FromBody] Book book)
        {
            return booksDAO.insertar(book.Title, book.Chapters, book.Pages, book.Price, book.AuthorId);
        }
    }
}
