using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using Castle.DynamicProxy;

namespace projekt1
{
    public class MyInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            DateTime t1 = DateTime.Now;
            invocation.Proceed();
            DateTime t2 = DateTime.Now;
            TimeSpan ts = t2 - t1;
            Trace.WriteLine(string.Format("Pomiar: {0} s", ts.Seconds));
        }
    }
}