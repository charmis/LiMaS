using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("home/index")]
        public IActionResult Index()
        {
            return Ok("Hello World from a controller");
        }
    }
}
