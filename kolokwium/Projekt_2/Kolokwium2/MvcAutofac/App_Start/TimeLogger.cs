using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Castle.DynamicProxy;

namespace MvcAutofac.App_Start
{
    public class TimeLogger : IInterceptor
    {
        private readonly TextWriter _output;

        public TimeLogger(TextWriter output)
        {
            _output = output;
        }

        public void Intercept(IInvocation invocation)
        {
            _output.WriteLine("Method {0} with parameters {1}... ", invocation.Method.Name, string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));
            var watch = Stopwatch.StartNew();
            invocation.Proceed();
            watch.Stop();
            _output.WriteLine("Done: result was {0}.", invocation.ReturnValue);

            var elapsedMs = watch.ElapsedMilliseconds;
            Trace.WriteLine(string.Format("Czas wykonania {0}.", elapsedMs));
        }
    }
}