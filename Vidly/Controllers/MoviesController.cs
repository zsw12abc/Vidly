using System;
using System.Drawing;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Secret"};

            return View(movie);
//            return new ViewResult();
//            return Content("Hello World");
//            return new EmptyResult();
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //GET Movies/pageIndex=&sortBy=
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}