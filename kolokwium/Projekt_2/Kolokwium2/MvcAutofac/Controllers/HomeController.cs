using System.Web.Mvc;
using SomeClass;

namespace MvcAutofac.Controllers
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
            return View();
        }
    }
}