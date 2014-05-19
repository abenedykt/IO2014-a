using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using intercept.Models;

namespace intercept.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISomeType _type;

        public HomeController(ISomeType type)
        {
            _type = type;
        }

        public ActionResult Index()
        {
            this._type.Show();

            return View();
        }
	}
}