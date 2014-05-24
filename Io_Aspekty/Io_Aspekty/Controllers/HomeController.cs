using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Extras.DynamicProxy2;
using Io_Aspekty.Models;
using Io_Aspekty;

namespace Io_Aspekty.Controllers
{
    public class HomeController : Controller
    {
        ISomeModel cs;

        public HomeController(ISomeModel cs)
        {
            this.cs = cs;
        }

        [Route]
        public ActionResult Index()
        {
            return View(cs.Method());
        }
    }
}