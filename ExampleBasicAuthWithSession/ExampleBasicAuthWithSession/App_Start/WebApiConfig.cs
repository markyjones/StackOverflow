using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Thinktecture.IdentityModel.Tokens.Http;

namespace ClientCredentialsGrantExample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var authentication = CreateAuthenticationConfiguration();

            // session support for all requests
            config.MessageHandlers.Add(new AuthenticationHandler(authentication));

            // enable sessions on token provider controller
            authentication.EnableSessionToken = true;
            
            config.Routes.MapHttpRoute(
                name: "TokenApi",
                routeTemplate: "api/token/{action}",
                defaults: new { controller = "token" },
                constraints: null,
                handler: new AuthenticationHandler(authentication, config)
            );

            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}",
               defaults: null,
               constraints: null
           );

            config.EnableSystemDiagnosticsTracing();

        }

        private static AuthenticationConfiguration CreateAuthenticationConfiguration()
        {
            const string signingKey = "fWUU28oBOIcaQuwUKiL01KztD/CsZX83C3I0M1MOYN4=";

            var confing = new SessionTokenConfiguration();
            confing.Scheme = "Session";
            confing.SigningKey = signingKey;

            var authentication = new AuthenticationConfiguration
            {
                RequireSsl = false,
                EnableSessionToken = true,
                SessionToken = confing,
            };

            authentication.DefaultAuthenticationScheme = "Basic";

            authentication.AddBasicAuthentication((username, password) => IsAuthenticated(username, password));
            
            //Use this to prevent your browser showing the standard basic auth login dialog on failure.
            authentication.SendWwwAuthenticateResponseHeader = false;
            
            return authentication;
        }

        private static bool IsAuthenticated(string username, string password)
        {
            return username.Equals(password, StringComparison.CurrentCultureIgnoreCase);
        }

    }
}
