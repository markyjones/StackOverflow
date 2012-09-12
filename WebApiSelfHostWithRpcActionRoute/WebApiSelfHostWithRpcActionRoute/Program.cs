using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Http.SelfHost;

namespace WebApiSelfHostWithRpcActionRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up server configuration 
            HttpSelfHostConfiguration config = new HttpSelfHostConfiguration("http://localhost:8080");

            //Route Catches the GET PUT DELETE typical REST based interactions (add more if needed)
            config.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
                new { id = RouteParameter.Optional },
                new { httpMethod = new HttpMethodConstraint(HttpMethod.Get, HttpMethod.Put, HttpMethod.Delete) });

            //This allows POSTs to the RPC Style methods http://api/controller/action
            config.Routes.MapHttpRoute("API RPC Style", "api/{controller}/{action}",
                new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) });

            //Finally this allows POST to typeical REST post address http://api/controller/
            config.Routes.MapHttpRoute("API Default 2", "api/{controller}/{action}",
                new { action = "Post" },
                new { httpMethod = new HttpMethodConstraint(HttpMethod.Post) });
            
            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
