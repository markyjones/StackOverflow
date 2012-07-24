using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dispatcher;

namespace ControllerExceptionHandling
{
    public class YourCustomControllerActivator : IHttpControllerActivator
    {
        private readonly IHttpControllerActivator _default = new DefaultHttpControllerActivator();

        public YourCustomControllerActivator()
        {

        }

        public System.Web.Http.Controllers.IHttpController Create(System.Net.Http.HttpRequestMessage request, System.Web.Http.Controllers.HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            try
            {
                return _default.Create(request, controllerDescriptor, controllerType);
            }
            catch (InvalidOperationException e)
            {
                if (e.InnerException is ArgumentNullException)
                {
                    var x = 1;
                    //DO SOMETHING WITH THE ORIGIONAL ERROR!
                }

                //DO SOMETHING WITH THE ORIGIONAL ERROR!
                return null;
            }
            
        }
    }
}