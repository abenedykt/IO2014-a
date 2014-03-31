using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abstract;

namespace MVCDependency.Controllers
{
    public class TextController : Controller
    {
        private IEvent Event;
        private IRepository Repository;
        private IApplication Application;

        public TextController(IEvent Event, IRepository Repository, IApplication Application)
        {
            this.Event = Event;
            this.Repository = Repository;
            this.Application = Application;
        }

        //
        // GET: /Text

        public ActionResult Index()
        {
            Repository.GetAll();

            return View();
        }

    }
}
