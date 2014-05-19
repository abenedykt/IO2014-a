using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using Castle.DynamicProxy;
using intercept.Models;

namespace intercept.App_Start
{
    public class CallLogger : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("uruchomiono");

            invocation.Proceed();

            Debug.WriteLine("ukonczono");
        }
    }

    public class DependencyConfig
    {
        public static void RegisterDependency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SomeType>()
                   .As<ISomeType>()
                   .EnableInterfaceInterceptors()
                   .InterceptedBy(typeof(CallLogger));

            builder.Register(c => new CallLogger());
            builder.RegisterControllers(Assembly.GetExecutingAssembly());


            var container = builder.Build();

            //var willBeIntercepted = container.Resolve<ISomeType>();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}