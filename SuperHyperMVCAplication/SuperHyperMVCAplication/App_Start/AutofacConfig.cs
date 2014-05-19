using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Extras.DynamicProxy2;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace SuperHyperMVCAplication.App_Start
{


    public class CallLogger : IInterceptor
    {

        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("Wywolano");
            invocation.Proceed();
            Debug.WriteLine("Zakonczono metode");
           

        }
    }

    public class AutofacConfig
    {
        public static void RegisterDependences()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<MasterComputing>().As<IMasterComputing>().EnableInterfaceInterceptors();
   
          //  builder.RegisterFilterProvider();

            builder.Register(c => new CallLogger());


            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}