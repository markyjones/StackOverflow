using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FormsAuthAndWebApi.Controllers

{
   
    public class SecuredController : ApiController
    {
        // GET api/secured
        [System.Web.Http.Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/secured/5
       
        public string Get(int id)
        {
            return "value";
        }

        // POST api/secured
     
        public void Post(string value)
        {
        }

        // PUT api/secured/5
        
        public void Put(int id, string value)
        {
        }

        // DELETE api/secured/5
        
        public void Delete(int id)
        {
        }
    }
}
