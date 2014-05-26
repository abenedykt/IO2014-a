using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using utility;

namespace solucja2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISomeStuff _stuff;

        public HomeController(ISomeStuff stuff)
        {
            _stuff = stuff;
        }

        public ViewResult Index()
        {
            _stuff.MakeSomeWork();

            return new ViewResult();
        }
	}
}