using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TDD_Lab_01;

namespace AngularJS_Zad_1.Controllers
{
    public class FizzBuzzController : ApiController
    {
        public string Get(int id)
        {
            var fb = new FissBass();

            if (id == 0)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return fb.Play(id).ToString();
        } 
    }
}
