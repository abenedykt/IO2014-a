using System;
using System.Diagnostics;
using Castle.DynamicProxy;

namespace MVCAutoFac
{
    public class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
          
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
              
            }

        }
    }
}