using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Autofac;
using Autofac.Integration.Mvc;
using Application;
using IApplication;
using Repository;
using IRepository;

namespace AutofacTest
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            RegisterIoc();
        }

        private void RegisterIoc()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(Global).Assembly);
            RegisterDependencies(builder);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

        private void RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationC>().As<IApplicationC>();
            builder.RegisterType<TxtRepository>().As<IRepositoryC>();
        }
    }
}