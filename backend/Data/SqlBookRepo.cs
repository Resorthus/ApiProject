using System;
using System.Collections.Generic;
using System.Linq;
using ApiProject.Models;

namespace ApiProject.Data
{
    public class SqlBookRepo : IBookRepo
    {
        private readonly ApiProjectContext _context;

        public SqlBookRepo(ApiProjectContext context)
        {
            _context = context;
        }

        public void Create(Book book)
        {
            if(book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            _context.Books.Add(book);
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}