using LogikaZadanieMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZadanieMvc.Controllers
{
    public class HomeController : Controller
    {

        private ISomeStuff _stuff;

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