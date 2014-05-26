using LongRunningStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private ISomeStuff _stuff;

        public HomeController(ISomeStuff stuff)
        {
            _stuff = stuff;
        }

        public ViewResult Index()
        {
            _stuff.MakeSomeWork();
            return View();
        }
	}
}