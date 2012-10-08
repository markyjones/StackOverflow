using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiControllerRouteUrlExample.Controllers
{
    public class ClientsController : ApiController
    {
        [HttpGet]
        public string GetClients(int id)
        {
            return "Test";
        }
    }
}
