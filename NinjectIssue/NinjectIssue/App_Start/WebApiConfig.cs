using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NinjectIssue
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
  
            config.Routes.MapHttpRoute(
             name: "ProfileRestApi",
             routeTemplate: "api/profile/{id}",
             defaults: new { id = RouteParameter.Optional, Controller = "Profile" }
             );

          
            config.Routes.MapHttpRoute(
                name: "PrfileRpcApi",
                routeTemplate: "api/profile/{action}/{rpcId}",
                defaults: new { Controller = "Profile" }
            );

           

          
            config.Routes.MapHttpRoute(
                name: "DefaultRestApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultRpcApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
