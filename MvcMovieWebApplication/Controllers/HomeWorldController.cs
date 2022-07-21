using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovieWebApplication.Controllers
{
    public class HomeWorldController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = ID;

            return View();
        }
    }
}
