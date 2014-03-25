using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FizzBuzzGame_lab1;
using TDD_lab_01;

namespace AngularZad1.Controllers
{
    public class FizzBuzzController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {
            var fb = new FizzBuzz(new string[1] { id.ToString() });

            if (!fb.ReturnCollection().Any())
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return Request.CreateResponse<object>(HttpStatusCode.OK, fb.ReturnCollection().Select(item => item).ToArray());

        }
    }
}