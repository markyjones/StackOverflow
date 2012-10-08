SO Question response for http://stackoverflow.com/questions/12739635/setting-asp-net-mvc4-web-api-route-url-in-javascript-is-returning-empty-string/12785806#12785806

Browse to /home for example output

Route 1: /api/Client/clients

Route 2: /api/client2/clients

from routes:

			config.Routes.MapHttpRoute(
                  name: "ApiControllerAction2",
                  routeTemplate: "api/client2/clients/{id}",
                  defaults: new { id = RouteParameter.Optional, controller = "Clients" }
              );

            config.Routes.MapHttpRoute(
                name: "ApiControllerAction",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional });

And razor:

<p>
    Route 1: @Url.RouteUrl("ApiControllerAction", new { httproute="", controller = "Client", action = "clients" }) 
</p>
<p>
    Route 2: @Url.RouteUrl("ApiControllerAction2", new { httproute="", controller = "Clients" })
</p>