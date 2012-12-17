using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using MvcApplication3.Models;
using Thinktecture.IdentityModel.Tokens.Http;
using System.Web.Security;
using System.Web.Http;
using WebMatrix.WebData;
using MvcApplication3.Filters;
using System.Data.Entity;
using System.Web;

namespace MvcApplication3
{
    public static class AuthConfig
    {
        public static void RegisterAuth(HttpConfiguration config)
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            //OAuthWebSecurity.RegisterFacebookClient(
            //    appId: "",
            //    appSecret: "");

            //OAuthWebSecurity.RegisterGoogleClient();


            var authConfig = new AuthenticationConfiguration();
            
            authConfig.AddBasicAuthentication((userName, password) =>
            {
                return Membership.ValidateUser(userName, password);
            });

            authConfig.InheritHostClientIdentity = true;

            config.MessageHandlers.Add(new AuthenticationHandler(authConfig));
        }
    }
}
