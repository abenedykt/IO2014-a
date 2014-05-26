using System;
using System.Diagnostics;
using System.Web.Mvc;
using Zad2MVC.Abstractions;

namespace Zad2MVC.Controllers
{
    public class HomeController : Controller
    {
        private ISomeStuff _stuff;

        public HomeController(ISomeStuff stuff)
        {
            _stuff = stuff;
        }

        [Route]
        public ViewResult Index()
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            _stuff.MakeSomeWork();
            sw.Stop();

            Trace.WriteLine("Czas wykonania metody to {0}", sw.ToString());
            return View();
            
        }
    }

   
}