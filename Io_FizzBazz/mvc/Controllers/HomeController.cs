using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tdd;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public IEnumerable<string> GetFizzBazz(int ile)
        {
            List<string> lista = new List<string>();
            FizzBazz fb = new FizzBazz();

            for (int i = 1; i <= ile; i++)
            {
                lista.Add(fb.Play(i));
            }

            return lista;
        }

        [HttpGet]
        public ActionResult FizzBazz(string ile)
        {
            int n = 0;
            bool b = int.TryParse(ile, out n);
            if (b)
            {
                IEnumerable<string> lista = GetFizzBazz(n);
                ViewBag.lista = lista;
            }
            return View();
        }
    }
}
