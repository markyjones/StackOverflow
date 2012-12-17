using MvcApplication3.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication3.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class GooberController : ApiController
    {
        
        public string Get(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                return "IsAuthed";
            }

            return "test";
        }
    }
}
