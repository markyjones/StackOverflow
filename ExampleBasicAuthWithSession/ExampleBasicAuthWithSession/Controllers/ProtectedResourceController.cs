using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientCredentialsGrantExample.Controllers
{
    [Authorize]
    public class ProtectedResourceController : ApiController
    {
        public string Get()
        {
            return "Hiya";
        }
    }
}
