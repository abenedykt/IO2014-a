using AutofacLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autofac.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISomeStuff _stuff;

        public HomeController(ISomeStuff stuff)
        {
            _stuff = stuff;
        }

        public ActionResult Index()
        {
            _stuff.MakeSomeWork();
            return View();
        }
	}
}