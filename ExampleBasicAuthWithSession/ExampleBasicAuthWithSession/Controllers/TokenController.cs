using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientCredentialsGrantExample.Controllers
{
    public class TokenController : ApiController
    {
        // POST api/token
        [Authorize]
        public void Post()
        {
        }
    }
}