using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Autofac.Interceptor
{
    public class TimeLogger : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var watch = Stopwatch.StartNew();
            invocation.Proceed();
            Trace.WriteLine("Pomiar: {0} ms", watch.ElapsedMilliseconds.ToString());
        }
    }
}