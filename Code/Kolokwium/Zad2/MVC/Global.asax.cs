using Autofac;
using Autofac.Integration.Mvc;
using LongRunningStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac.Extras.DynamicProxy2;

namespace MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            RegisterAutofac();
        }

        private void RegisterAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SomeLongRunningStuff>().As<ISomeStuff>().EnableInterfaceInterceptors().InterceptedBy(typeof(Interceptor));
            builder.RegisterInstance(new Interceptor()).AsSelf();
            
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
