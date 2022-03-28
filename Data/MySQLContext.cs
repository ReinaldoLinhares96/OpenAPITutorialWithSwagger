using Microsoft.EntityFrameworkCore;
using BooksApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApp.API.Data
{
    public class MySQLContext: DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
