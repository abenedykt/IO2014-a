using System.Web.Mvc;
using Logic;

namespace MVCAutoFac.Controllers
{
    public class HomeController : Controller
    {
        public ISomeStuff stuff { get; set; }

        public HomeController(ISomeStuff stuff)
        {
            this.stuff = stuff;
        }
        public ActionResult Index()
        {
            stuff.MakeSomeWork();
            return View();
        }

    }
}
