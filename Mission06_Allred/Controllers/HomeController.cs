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
        public IActionResult MovieForm()
        {
            ViewBag.categories = _context.Category.ToList();

            return View("MovieForm", new Movie());
        }

        [HttpPost]
        public IActionResult MovieForm(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Add record to database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else //Invalid data
            {
                ViewBag.categories = _context.Category.ToList();

                return View(response);
            }
        }

        public IActionResult ViewMovies()
        {
            //Linq
            var movies = _context.Movies.ToList();

            ViewBag.categories = _context.Category.ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(m => m.MovieID == id);

            ViewBag.categories = _context.Category.ToList();

            return View("MovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedMovie)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();

            return RedirectToAction("ViewMovies");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(m => m.MovieID == id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("ViewMovies");
        }

    }
}
