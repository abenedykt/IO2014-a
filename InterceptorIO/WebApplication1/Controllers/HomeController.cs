using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
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