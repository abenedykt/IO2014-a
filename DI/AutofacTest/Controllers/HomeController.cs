using IApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutofacTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationC application;

        public HomeController(IApplicationC application)
        {
            this.application = application;
        }

        //
        // GET: /Home/
        public ActionResult Index()
        {
            var events = application.Events();
            return View(events);
        }
	}
}