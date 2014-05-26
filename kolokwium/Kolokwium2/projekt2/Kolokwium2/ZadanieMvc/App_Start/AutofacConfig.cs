using Autofac;
using Autofac.Integration.Mvc;
using Castle.DynamicProxy;
using Autofac.Extras.DynamicProxy2;
using LogikaZadanieMvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace ZadanieMvc.App_Start
{
    public class AutofacConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SomeLongRunningStuff>().As<ISomeStuff>().EnableInterfaceInterceptors().InterceptedBy(typeof(CallLogger));


            builder.Register(c => new CallLogger());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }



    }

    public class CallLogger : IInterceptor
    {
        

        public void Intercept(IInvocation invocation)
        {
    
            var watch = Stopwatch.StartNew();
            invocation.Proceed();
            watch.Stop();
            Trace.WriteLine(String.Format("Czas wykonania wyniósł: {0}ms", watch.ElapsedMilliseconds));

        }
    }
}