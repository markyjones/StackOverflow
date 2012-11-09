using Ninject.Activation;
using Ninject.Parameters;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace NinjectIssue
{
    public class NinjectDependencyScope : IDependencyScope
    {
        protected IResolutionRoot resolutionRoot;

        public NinjectDependencyScope(IResolutionRoot kernel)
        {
            resolutionRoot = kernel;
        }

        public object GetService(Type serviceType)
        {
            IRequest request = resolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
            return resolutionRoot.Resolve(request).SingleOrDefault();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            IRequest request = resolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
            return resolutionRoot.Resolve(request).ToList();
        }

        public void Dispose()
        {
            IDisposable disposable = (IDisposable)resolutionRoot;
            if (disposable != null) disposable.Dispose();
            resolutionRoot = null;
        }
    }
}