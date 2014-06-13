using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using Logic;

namespace MVCAutoFac
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
          
            RegIoC();
            RegIoC2();

        }

        private void RegIoC2()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SomeStuff>()
                .As<ISomeStuff>()
                .InstancePerRequest()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(TimeLogger))
                .InstancePerRequest();
            builder.Register(n => new TimeLogger());
            var container = builder.Build();
            builder.Register(n => new Interceptor());
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

        }


        private static void RegIoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof (MvcApplication).Assembly);

            builder.RegisterType<SomeStuff>()
                .As<ISomeStuff>()
                .InstancePerRequest()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof (Interceptor))
                .InstancePerRequest();
            builder.Register(n => new Interceptor());
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            builder.RegisterControllers(typeof(MvcApplication).Assembly);


        }
    }
}