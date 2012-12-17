using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

namespace NinjectIssue.Controllers
{
    public class ProfileRestController : ApiController
    {
        public string Get(int id)
        {
            return string.Format("http://localhost/api/profile/{0}", id);
        }

        public string Get()
        {
            return "http://localhost/api/profile";
        }

        [HttpGet]
        public string Ssn(int rpcId)
        {
            return string.Format("http://localhost/api/profile/ssn/{0}", rpcId);

        }

        [HttpGet]
        public string Email(string rpcId)
        {
            return string.Format("http://localhost/api/profile/email/{0}", rpcId);

        }
    }
}
