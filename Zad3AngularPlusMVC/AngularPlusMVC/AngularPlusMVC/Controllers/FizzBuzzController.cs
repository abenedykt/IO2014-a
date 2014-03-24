using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace AngularPlusMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        //
        // GET: /FizzBuzz/

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult GetResult(int id)
        {
            var result = Enumerable.Range(0, id).ToArray();

            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = js.Serialize(result);

            return Json(json, JsonRequestBehavior.AllowGet);
        }

    }
}
