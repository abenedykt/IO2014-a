using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using Castle.DynamicProxy;

namespace Io_Aspekty
{
    public class MyInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Debug.WriteLine("Przed");
            invocation.Proceed();
            Debug.WriteLine("Po");
        }
    }
}