using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=LibraryDBConnectionString")
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}