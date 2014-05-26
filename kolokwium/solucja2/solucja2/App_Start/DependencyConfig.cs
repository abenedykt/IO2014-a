using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Extras.DynamicProxy2;
using Autofac.Integration.Mvc;
using Castle.DynamicProxy;
using utility;

namespace solucja2.App_Start
{
        public class CallLogger : IInterceptor
        {
            public void Intercept(IInvocation invocation)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                invocation.Proceed();

                stopWatch.Stop();

                // wynik zapisywany do application.log
                Trace.WriteLine(stopWatch.Elapsed);
            }
        }

        public class DependencyConfig
        {
            public static void RegisterDependency()
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<SomeLongRunningStuff>()
                       .As<ISomeStuff>()
                       .EnableInterfaceInterceptors()
                       .InterceptedBy(typeof(CallLogger));

                builder.Register(c => new CallLogger());
                builder.RegisterControllers(Assembly.GetExecutingAssembly());


                var container = builder.Build();

                DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            }
        }
}