using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1.Services
{
    public class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("begin");

            invocation.Proceed();

            Debug.WriteLine("begin");
        }
    }

    public interface ICService
    {
        void Method();
    }

    public class CService : ICService
    {
        public void Method()
        {

        }
    }
}