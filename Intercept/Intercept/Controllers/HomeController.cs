using Intercept.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intercept.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICService service;

        public HomeController(ICService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            service.Method();
            return View();
        }
	}
}