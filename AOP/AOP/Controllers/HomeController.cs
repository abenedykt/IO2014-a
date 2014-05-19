using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExampleClass;
namespace AOP.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExampleClass _klasa;
        private readonly IData _data;

        //public HomeController()
        //{
            
        //}
        public HomeController(IExampleClass klasa, IData data)
        {
            _klasa = klasa;
            _data = data;
        }

        [Route]
        public ActionResult Index()
        {
            _klasa.Name = "Marek";
            _klasa.Age = 22;

            var tmp = _data.ValueA();
            return View((object)tmp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}