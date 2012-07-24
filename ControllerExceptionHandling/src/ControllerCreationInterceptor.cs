using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControllerExceptionHandling
{
    public class ControllerCreationInterceptor : Ninject.Extensions.Interception.IInterceptor
    {

        public void Intercept(Ninject.Extensions.Interception.IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (InvalidOperationException e)
            {
                if (e.InnerException is ArgumentNullException)
                {
                    var x = 1;
                    //DO SOMETHING WITH THE ORIGIONAL ERROR!
                }
                
                //DO SOMETHING WITH THE ORIGIONAL ERROR!
            }
        }
    }
}