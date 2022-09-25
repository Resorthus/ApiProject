using System;
using System.Collections.Generic;
using ApiProject.Models;

namespace ApiProject.Data
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id); 
        void Create(Book book);

        bool SaveChanges();
    }
}