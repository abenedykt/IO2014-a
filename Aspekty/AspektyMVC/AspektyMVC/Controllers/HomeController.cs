using System.Configuration;
using System.Diagnostics;
using System.Web.Mvc;
using AspektyMVC.Models;
using Autofac;

namespace AspektyMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITemp _temp;
        private readonly IOpenable _openable;
        private readonly IClosable _closable;

        public HomeController(IOpenable open, IClosable close, ITemp temp)
        {
            _openable = open;
            _closable = close;
            _temp = temp;
        }

        [Route]
        public ActionResult Index()
        {
            Debug.WriteLine("Tekst przed");
            
            return View(_openable.OpenSomethink() as object);
           
        }

       
    }
}