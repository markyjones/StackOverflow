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

        [ActionName("Post")]
        [HttpPost]
        public void Post(TaskInstance taskInstance)
        {
            // Do something with my taskInstance
            Console.WriteLine("REST Post Method entered!");
        }

        [ActionName("Queue")]
        [HttpPost]
        public void Queue(TaskInstance taskInstance)
        {
            // Do something with my taskInstance
            Console.WriteLine("Queue Method entered!");
        }

        [ActionName("Another")]
        [HttpPost]
        public void Another(TaskInstance taskInstance)
        {
            Console.WriteLine("Another Method entered!");
        }
    }
}
