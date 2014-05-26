using System.Diagnostics;
using System.Web.Mvc;
using Autofac;
using SomeLongRunning;

namespace project2.Controllers
{
    public class HomeController : Controller
    {
        

        private ISomeStuff _stuff;

        private static IContainer Container { get; set; }
        public HomeController(ISomeStuff stuff)
        {          
            _stuff = stuff;
        }

        public ActionResult Index()
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<SomeLongRunningStuff>().As<ISomeStuff>();
            Container = builder.Build();
           

            Stopwatch s = new Stopwatch();
            s.Start();
            
            _stuff.MakeSomeWork();
            s.Stop();
            Trace.WriteLine(s.ElapsedMilliseconds);
            return View();

           
        }

    }


}
