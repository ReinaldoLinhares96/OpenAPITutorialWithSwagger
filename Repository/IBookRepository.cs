using BooksApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApp.API.Repository
{
    public interface IBookRepository
    {
        List<Book> FindAll();
    }
}


