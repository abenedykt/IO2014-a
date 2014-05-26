using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MVC_projekt2;

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
            return ViewResult();
        }

        private ViewResult ViewResult()
        {
            Trace.WriteLine()
        }

    }
}