using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IApplicationCL;

namespace applicationWPF.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplication appRepo;

        public HomeController(IApplication appRepo)
        {
            this.appRepo = appRepo;
        }

        public ActionResult Index()
        {
            return View(this.appRepo.Events());
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