using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;

namespace LongRunningStuff
{
    public interface ISomeStuff
    {
        void MakeSomeWork();
    }

    public class SomeLongRunningStuff : ISomeStuff
    {
        public void MakeSomeWork()
        {
            Thread.Sleep(10000);
        }
    }


    public class Interceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var timer = new Stopwatch();

            timer.Start();
            invocation.Proceed();
            timer.Stop();

            Trace.WriteLine(string.Format("Czas wykonania metody {0} to {1}", invocation.Method.Name, timer.Elapsed));
        }
    }
}
