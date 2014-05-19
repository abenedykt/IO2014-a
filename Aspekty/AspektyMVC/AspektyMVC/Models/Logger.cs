using System.IO;
using System.Linq;
using Castle.DynamicProxy;

namespace AspektyMVC.Models
{
    public class Logger : IInterceptor
    {
        private TextWriter _output;

        public Logger(TextWriter output)
        {
            _output = output;
        }

        public void Intercept(IInvocation invocation)
        {
            _output.Write("Calling method {0} with parameters {1}... ",
                invocation.Method.Name,
                string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));

            invocation.Proceed();

            _output.WriteLine("Done: result was {0}.", invocation.ReturnValue);
        }
    }

    public interface IInterceptor
    {
    }
}