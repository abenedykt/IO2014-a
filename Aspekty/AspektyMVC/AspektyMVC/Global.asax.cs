using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AspektyMVC.Models;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;

namespace AspektyMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterContainers();
            
        }

        private void RegisterContainers()
        {
            // add builder for Autofac
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<Temp>().As<ITemp>().EnableClassInterceptors();
            builder.RegisterType<Open>().As<IOpenable>().EnableClassInterceptors();
            builder.RegisterType<Close>().As<IClosable>().EnableClassInterceptors();

            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            builder.Register(c => new Logger(Console.Out)).Named<IInterceptor>("logi");
            //build.RegisterType(myType).As(ImyType).EnableInterfaceInterceptors().InterceptedBy(typeof(Aspect));
            

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        
    }
}
