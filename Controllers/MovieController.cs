using Microsoft.AspNetCore.Mvc;
using Mission06_Summerill.Models;

namespace Mission06_Summerill.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieCollectionContext _context;

        public MovieController(MovieCollectionContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Confirmation");
            }

            return View(movie);
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
