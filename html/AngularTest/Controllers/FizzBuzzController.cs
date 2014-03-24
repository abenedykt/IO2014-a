using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FizzBuzz;

namespace AngularTest.Controllers
{
    public class FizzBuzzController : ApiController
    {
        public IEnumerable<string> Get(int count)
        {
            var game = new FizzBuzzGame();
            return game.Range(count);
        }
    }
}
