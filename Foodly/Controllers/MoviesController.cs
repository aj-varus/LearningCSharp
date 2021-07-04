using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Foodly.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Foodly.Controllers
{
    public class MoviesController : Controller
    {
        private  List<Movie> Movies { get; set; }

        public MoviesController()
        {
            Movies = new List<Movie>
            {
                new Movie
                {
                    Name = "Titanic",
                    Id = 1
                },

                new Movie
                {
                    Name = "Tormentor",
                    Id = 2
                }
            };
        }
        public IActionResult Random()
        {
            var movie = new Movie { Name = "Shrek" };

            return View(movie);
        }

        [Route("Movies/released/{year:int?}/{month:int?}")]
        public IActionResult ByReleaseDate(int year = 2010, int month = 05)
        {
            return Content($"{year}/{month}");
        }

        public IActionResult Index()
        {
            return View(Movies);
        }

        public IActionResult Details(int id)
        {
            var movie = Movies.SingleOrDefault(movie => movie.Id == id);

            if (movie is null) return Content("Error 404");

            return View(movie);

        }


    }
}
