using SpodIglyMVC.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            return View();
        }

        [ChildActionOnly]
        public ActionResult GenresMenu()
        {
            var genres = db.Genres.ToList();

            return PartialView(genres);
        }
    }
}