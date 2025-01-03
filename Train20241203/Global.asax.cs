﻿using Autofac;
using Autofac.Integration.Web;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Train20241203.Api;
using Train20241203.DB;

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

        protected void Application_AuthorizeRequest(object sender, EventArgs e)
        {
            // Resolve the dependencies from the container and set them
            // to the properties of the current HttpContext.
            var context = new HttpContextWrapper(HttpContext.Current);

          
            //var builder = new ContainerBuilder();
            //builder.RegisterType<Crypt>().As<ICrypt>();
            //builder.RegisterType<BBClass>().As<IBBClass>();
            //builder.Register(c => new DBClass(""));

            //_containerProvider = new ContainerProvider(builder.Build());


        }

        protected void Application_Start(object sender, EventArgs e)
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<Crypt>().As<ICrypt>();            
            builder.RegisterType<BBClass>().As<IBBClass>();

            builder.Register(c => new DBClass(""));
            builder.Register(c => new AdminMethods()).SingleInstance();
            
            builder.Register(c => new DataClasses1DataContext()).SingleInstance();



            // ... continue registering dependencies...

            // Once you're done registering things, set the container
            // provider up with your registrations.
            _containerProvider = new ContainerProvider(builder.Build());








            // Build up your application container and register your dependencies.
            // var conn = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["TestDBConnectionString"].ConnectionString;
            //var builder = new ContainerBuilder();
            //builder.RegisterType<Fun>().As<IFun>();
            //builder.RegisterType<Fun2>().As<IFun2>();
            // ... continue registering dependencies...

            // Once you're done registering things, set the container
            // provider up with your registrations.
            //_containerProvider = new ContainerProvider(builder.Build());

        }
    }
}