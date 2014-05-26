using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zawiera1klase;

namespace mvc_autofac.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISomeStuff _stuff;
        private readonly ITimeCount _timeCount;

        public HomeController(ISomeStuff stuff, ITimeCount timeCount)
        {
            _stuff = stuff;
            _timeCount = timeCount;
        }

        public ViewResult Index()
        {
            _stuff.MakeSomeWork();

            return ViewResult(_timeCount.Timer());
            
        }
	}
}