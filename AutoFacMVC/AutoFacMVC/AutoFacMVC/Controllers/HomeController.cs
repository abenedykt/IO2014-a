using System.Web.Mvc;
using BussinesLogic;


namespace AutoFacMVC.Controllers
{
    // czym jest CircularReferences?
    //  class1 uzywa class2 a class 2 uzywa class3 a class3 uzywa class 1
    // dopuki to mamy w 1 .dll to nie ma problemu
    // problem robi sie gdy piszemy z wykraczaniem dllek ( gdy kazda klasa jest w odzielnej dll )
    // to visual studio nie pozwoli nam czegos takiego zrobic

    // circular reference jest bardzo zle
    // gdy wprowadzamy zmiany dla Class1
    // zwby skompilowac plik Class1 to potrzebujemy Class2
    // nie jestesmy w stanie nic kompilowac

    // w przypadku dynamicznego ładowania dll to kod bedzie zachowywal sie dziwnie
    // jedna z zasad SOLID mowi o tym, że klasy powinny zależeć od abstrakcji
    // jedna klasa zalezy od abstrakcji a druga implementuje abstrakcje
    public class HomeController : Controller
    {
        private readonly IApplication _application;

        public HomeController(IApplication app)
        {
            _application = app;
        }
        public ActionResult Index()
        {
            var events = _application.Events();
            return View(events);
        }
    }
}