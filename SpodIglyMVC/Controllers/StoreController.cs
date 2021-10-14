using SpodIglyMVC.DAL;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;

namespace SpodIglyMVC.Controllers
{
    public class StoreController : Controller
    {
        private StoreContext db = new StoreContext();

        public ActionResult Details(int id)
        {
            var album = db.Albums
                .Find(id);

            return View(album);
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
        [OutputCache(Duration = 80000)]
        public ActionResult GenresMenu()
        {
            var genres = db.Genres.ToList();

            return PartialView("_GenresMenu", genres);
        }

        public ActionResult AlbumsSuggestions(string term)
        {
            var albums = db.Albums
                .Where(a => a.AlbumTitle.ToLower().Contains(term.ToLower()) && !a.IsHidden)
                .Take(5)
                .Select(a => new { label = a.AlbumTitle });

            return Json(albums, JsonRequestBehavior.AllowGet);
        }
    }
}