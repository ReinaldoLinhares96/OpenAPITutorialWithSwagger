using BooksApp.API.Data;
using BooksApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApp.API.Repository.Implementation
{
    public class BookRepository : IBookRepository
    {
        private MySQLContext _context;

        public BookRepository(MySQLContext context)
        {
            _context = context;
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }
    }
}


