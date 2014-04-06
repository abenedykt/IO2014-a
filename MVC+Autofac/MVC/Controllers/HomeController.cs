using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.BusinessLogic;
namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplication _application;

        public HomeController(IApplication app)
        {
            _application = app;
        }
        public ActionResult Index()
        {
            var events = _application.Events();
            return View(events);
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