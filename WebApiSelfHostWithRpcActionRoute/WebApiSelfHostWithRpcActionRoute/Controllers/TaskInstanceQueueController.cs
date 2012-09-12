using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiSelfHostWithRpcActionRoute.Controllers
{
    public class TaskInstanceQueueController : ApiController
    {

        public void Get(string id)
        {
            // Do something with my taskInstance
            Console.WriteLine("Method entered!" + id);
        }

        [HttpPost]
        public void Queue(TaskInstance taskInstance)
        {
            // Do something with my taskInstance
            Console.WriteLine("Method entered!");
        }
    }
}
