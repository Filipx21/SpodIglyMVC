using SpodIglyMVC.DAL;
using SpodIglyMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();
        public ActionResult Index()
        {
            var genres = db.Genres;
            var newArrivals = db.Albums
                .Where(x => x.IsHidden == false)
                .OrderByDescending(a => a.DateAdded)
                .Take(3)
                .ToList();
            var bestseller = db.Albums
                .Where(x => x.IsHidden == false && x.IsBestseller)
                .OrderBy(x => Guid.NewGuid())
                .Take(3)
                .ToList();
            var vm = new HomeViewModel()
            {
                Bestsellers = bestseller,
                Genres = genres,
                NewArrivals = newArrivals
            };

            return View(vm);
        }

        public ActionResult StaticContent(string viewname) 
        {
            return View(viewname);
        }


    }
}