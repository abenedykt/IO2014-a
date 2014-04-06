using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IApplicationC;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplication application;

        public HomeController(IApplication application)
        {
            this.application = application;
        }


        public ActionResult Index()
        {
            return View(application.Events());
        }
    }
}