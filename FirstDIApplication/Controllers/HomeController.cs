using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IApplicationClassLibrary;

namespace FirstDIApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplication iapplication;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult List()
        {
            return View(iapplication.Compute());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public HomeController(IApplication iap)
        {
            iapplication = iap;
        }
    }
}