using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NinjectIssue.Controllers
{
    public class ProfileRpcController : ApiController
    {
        [HttpGet]
        public string Ssn(int id)
        {
            return string.Format("http://localhost/api/profile/ssn/{0}",id);

        }

        [HttpGet]
        public string Email(string id)
        {
            return string.Format("http://localhost/api/profile/email/{0}", id);

        }
    }
}
