using SpodIglyMVC.DAL;
using SpodIglyMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
    public class CartController : Controller
    {
        private ISessionManager sessionManager { get; set; }
        private ShoppingCartManager shoppingCartManager;
        private StoreContext db;

        public CartController()
        {
            this.sessionManager = new SessionManager();
            this.shoppingCartManager = new ShoppingCartManager(sessionManager, db);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(int id)
        {
            shoppingCartManager.AddToCart(id);
            return RedirectToAction("Index");
        }
    }
}