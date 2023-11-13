using Data.Models;
using Data.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsDAO authorsDAO = new AuthorsDAO();

        [HttpGet("authors")]
        public List<Author> getAuthors()
        {
            return authorsDAO.seleccionarTodos();
        }


        [HttpPost("authors")]
        public bool CreateAuthor([FromBody] Author author)
        {
            return authorsDAO.insertar(author.Name);
        }
    }
}
