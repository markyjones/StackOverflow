using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace WebApiSelfHostWithRpcActionRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up server configuration 
            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration("http://localhost:8080");
            
            config.Routes.MapHttpRoute("API Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });
            config.Routes.MapHttpRoute("API RPC Style", "api/{controller}/{action}", new { });


            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
