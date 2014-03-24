using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MsTest;

namespace FizzMVC.Controllers
{
    public class FizzWebController : ApiController
    {
        public string[] Play(int id)
        {
            return new FizzBuzz().PlayRange(id).ToArray();
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[]{};
        }

        // GET api/<controller>/5
        public IEnumerable<string> Get(int id)
        {
            return new FizzBuzz().PlayRange(id).ToArray();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}