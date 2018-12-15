using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WestminsterConfession.v1.Web.Controllers
{
    public class WooController : ApiController
    {
        // GET: api/Woo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Woo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Woo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Woo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Woo/5
        public void Delete(int id)
        {
        }
    }
}
