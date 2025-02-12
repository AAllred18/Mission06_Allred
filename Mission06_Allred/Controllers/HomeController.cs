using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Allred.Models;

namespace Mission06_Allred.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private MovieSubmissionContext _context;

        public HomeController(MovieSubmissionContext temp) //Constructor
        { 
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie response)
        {
            _context.Movies.Add(response); //Add record to database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
