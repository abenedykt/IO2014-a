using System.Diagnostics;
using Castle.DynamicProxy;

namespace MVCAutoFac
{
    public class TimeLogger : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                invocation.Proceed();
            }
            catch
            {
                Trace.WriteLine(string.Format("Loading after {0}", stopwatch.ElapsedMilliseconds));
            }
         
        }
    }
}