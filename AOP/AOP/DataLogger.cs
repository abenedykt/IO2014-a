﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Autofac;
using Castle.DynamicProxy;

namespace AOP
{
    public class DataLogger : IInterceptor
    {
        TextWriter _output;

        public DataLogger(TextWriter output)
        {
            _output = output;
        }

        public void Intercept(IInvocation invocation)
        {
            _output.Write("Data method {0} with parameters {1}... ",
                invocation.Method.Name,
                string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));

            invocation.Proceed();

            _output.WriteLine("Done: result was {0}.", invocation.ReturnValue);
        }
    }
}