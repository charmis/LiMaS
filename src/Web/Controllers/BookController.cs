using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryContext _libraryContext;

        public BookController(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public IActionResult List()
        {
            return View(_libraryContext.Books.ToList());
        }

        public IActionResult Add()
        {
            _libraryContext.Books.Add(new Book { Title = "BookA" });
            _libraryContext.Books.Add(new Book { Title = "BookB" });
            _libraryContext.Books.Add(new Book { Title = "BookC" });
            _libraryContext.Books.Add(new Book { Title = "BookD" });
            _libraryContext.Books.Add(new Book { Title = "BookE" });

            _libraryContext.SaveChanges();

            return new JsonResult(new { StatusCode = "Success" });
        }
    }
}
