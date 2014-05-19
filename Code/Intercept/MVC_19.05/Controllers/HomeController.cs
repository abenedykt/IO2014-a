using MVC_19._05.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_19._05.Controllers
{
    public class HomeController : Controller
    {
        private ICService interceptor;

        public HomeController(ICService interceptor)
        {
            this.interceptor = interceptor;
        }

        public ActionResult Index()
        {
            interceptor.Method();
            return View();
        }
	}
}