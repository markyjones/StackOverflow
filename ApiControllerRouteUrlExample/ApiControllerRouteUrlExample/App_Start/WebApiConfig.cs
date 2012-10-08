using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApiControllerRouteUrlExample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                  name: "ApiControllerAction2",
                  routeTemplate: "api/client2/clients/{id}",
                  defaults: new { id = RouteParameter.Optional, controller = "Clients" }
              );

            config.Routes.MapHttpRoute(
                name: "ApiControllerAction",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional });


        }
    }
}
