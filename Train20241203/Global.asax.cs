using Autofac;
using Autofac.Integration.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Train20241203.Api;

namespace Train20241203
{
    public class Global : System.Web.HttpApplication, IContainerProviderAccessor
    {
        // Provider that holds the application container.
        static IContainerProvider _containerProvider;

        // Instance property that will be used by Autofac HttpModules
        // to resolve and inject dependencies.
        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            // Build up your application container and register your dependencies.
            // var conn = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["TestDBConnectionString"].ConnectionString;
            var builder = new ContainerBuilder();
            builder.RegisterType<Fun>().As<IFun>();
            builder.RegisterType<Fun2>().As<IFun2>();
            // ... continue registering dependencies...

            // Once you're done registering things, set the container
            // provider up with your registrations.
            _containerProvider = new ContainerProvider(builder.Build());

        }
    }
}