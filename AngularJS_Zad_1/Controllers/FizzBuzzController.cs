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
        public HttpResponseMessage Get(int id)
        {
            var fb = new FissBass(new string[1]{id.ToString()});

            if (!fb.ReturnCollection().Any())
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return Request.CreateResponse<object>(HttpStatusCode.OK, fb.ReturnCollection().Select(item => item ).ToArray());
            
        } 
    }
}
