using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Extras.DynamicProxy2;
using projekt1;
using projekt2;

namespace projekt1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RegisterContainer();
        }

        private void RegisterContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.Register(x => new MyInterceptor()).AsSelf();
            builder.RegisterType<SomeLongRunningStuff>().AsSelf();
            builder.RegisterType<SomeLongRunningStuff>().As<ISomeStuff>().EnableInterfaceInterceptors().InterceptedBy(typeof(MyInterceptor));
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
