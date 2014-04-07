using ApplicationClassLibrary;
using Autofac;
using IApplicationClassLibrary;
using IRepositoryClassLibrary;
using RepositoryTextClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDIApplication.App_Start
{
    public class AutofacConfig
    {
        public static void RegisterAutofacTypes(ContainerBuilder cb)
        {

         


            // Create your builder.
           // var builder = new ContainerBuilder();

            // Usually you're only interested in exposing the type
            // via its interface:
            cb.RegisterType<RepositoryText>().AsSelf().As<IRepository>();
            cb.RegisterType<Event>().AsSelf().As<IEvent>();
            cb.RegisterType<Application>().As<IApplication>();

            

            // However, if you want BOTH services (not as common)
            // you can say so:

        }
    }
}