using SpodIglyMVC.DAL;
using System.Linq;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
    public class StoreController : Controller
    {
        private StoreContext db = new StoreContext();

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult List(string genrename)
        {
            var genre = db.Genres
                .Include("Albums")
                .Where(g => g.Name.ToLower() == genrename.ToLower())
                .Single();
            var albums = genre.Albums
                .ToList();

            return View(albums);
        }

        [ChildActionOnly]
        public ActionResult GenresMenu()
        {
            var genres = db.Genres.ToList();

            return PartialView("_GenresMenu", genres);
        }
    }
}