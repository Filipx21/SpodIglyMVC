using SpodIglyMVC.DAL;
using SpodIglyMVC.Infrastructure;
using SpodIglyMVC.Models;
using SpodIglyMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();
        public ActionResult Index()
        {
            ICacheProvider cache = new DefaultCacheProvider();
            List<Album> newArrivals;

            var genres = db.Genres;
            if (cache.IsSet(Consts.NewArrivalsKey))
            {
                newArrivals = cache.Get(Consts.NewArrivalsKey) as List<Album>;
            }
            else
            {
                newArrivals = db.Albums
                                .Where(x => x.IsHidden == false)
                                .OrderByDescending(a => a.DateAdded)
                                .Take(3)
                                .ToList();
                cache.Set(Consts.NewArrivalsKey, newArrivals, 30);
            }

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