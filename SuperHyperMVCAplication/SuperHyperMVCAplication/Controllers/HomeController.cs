using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHyperMVCAplication.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMasterComputing _masterComputing;

        public HomeController(IMasterComputing masterComputing)
        {
            _masterComputing = masterComputing;
        }

        public ActionResult Index()
        {
            _masterComputing.ComputeSomeSheet(4);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}