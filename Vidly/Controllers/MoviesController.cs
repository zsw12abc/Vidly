using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET MovieS/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Secret"};
            
            return View(movie);
        }
    }
}