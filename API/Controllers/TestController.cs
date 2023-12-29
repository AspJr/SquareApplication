using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class TestController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok("Success to get response from API!");
        }
    }
}
