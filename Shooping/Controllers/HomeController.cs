using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shooping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult products()
        {
            ViewBag.Title = "Products";

            return View();
        }

        public ActionResult signin()
        {
            ViewBag.Title = "signin";

            return View();
        }

        public ActionResult single()
        {
            ViewBag.Title = "single";

            return View();
        }

        public ActionResult contact()
        {
            ViewBag.Title = "contact";

            return View();
        }

        public ActionResult cart()
        {
            ViewBag.Title = "cart";

            return View();
        }
    }
}