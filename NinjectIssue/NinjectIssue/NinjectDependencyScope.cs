
using Ninject;
using System;
using System.Web.Http.Dependencies;
namespace NinjectIssue
{
    public class NinjectDependencyScope : IDependencyScope
    {
        Ninject.Syntax.IResolutionRoot resolver;

        public NinjectDependencyScope(Ninject.Syntax.IResolutionRoot resolver)
        {
            this.resolver = resolver;
        }

        public object GetService(System.Type serviceType)
        {
            if (resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            var resolved = this.resolver.TryGet(serviceType);
            return resolved;
        }

        public System.Collections.Generic.IEnumerable<object> GetServices(System.Type serviceType)
        {
            if (resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            return this.resolver.GetAll(serviceType);
        }

        public void Dispose()
        {
            IDisposable disposable = resolver as IDisposable;
            if (disposable != null)
                disposable.Dispose();

            resolver = null;
        }
    }
}