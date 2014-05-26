using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Autofac.Integration.Mvc;
using AutofacLogic;
using Autofac.Extras.DynamicProxy2;
using Autofac.Interceptor;

namespace Autofac
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            RegisterIoC();
        }

        private void RegisterIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(Global).Assembly);
            Register(builder);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private void Register(ContainerBuilder builder)
        {
            builder.RegisterType<SomeLongRunningStuff>()
                .As<ISomeStuff>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TimeLogger));
        }
    }
}