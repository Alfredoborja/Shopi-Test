using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace ShopifyTest.Controllers
{
    public class pizzaController : ApiController
    {
        // GET: pizza
        [HttpGet]
        public HttpResponseMessage install(string shop, string host = "")
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;

        }
    }
}