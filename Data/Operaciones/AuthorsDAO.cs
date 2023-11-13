using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Context;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Operaciones
{
    public class AuthorsDAO
    {
        public LibreriaContext context = new LibreriaContext();

        public List<Author> seleccionarTodos()
        {
            var authors = context.Authors.Include(a => a.Book).ToList();
            return authors;
        }

        public Author seleccionar(int id)
        {
            var author = context.Authors.Include(a => a.Book)
                                        .SingleOrDefault(a => a.Id == id);
            return author;
        }


        public bool insertar(string Name)
        {
            try
            {
                Author author = new Author();
                author.Name = Name;

                context.Authors.Add(author);
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
