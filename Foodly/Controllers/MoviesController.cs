using Foodly.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foodly.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie { Name = "Shrek" };

            return View(movie);
        }
    }
}
