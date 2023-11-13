using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Data.Context;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Operaciones
{
    public class BooksDAO
    {
        public LibreriaContext context = new LibreriaContext();

        public List<Book> seleccionarTodos()
        {
            var books = context.Books.Include(b => b.Author).ToList();
            return books;
        }

        public Book seleccionar(int id)
        {
            var book = context.Books.Include(b => b.Author).SingleOrDefault(b => b.Id == id);
            return book;
        }

        //Método para insertar un nuevo alumno a la BD.
        public bool insertar(string Title, int Chapters, int Pages, decimal Price, int AuthorId)
        {
            try
            {
                Book book = new Book();
                book.Title = Title;
                book.Chapters = Chapters;
                book.Pages = Pages;
                book.Price = Price;
                book.AuthorId = AuthorId;

                context.Books.Add(book);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
