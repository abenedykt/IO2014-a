using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Autofac.Extras.DynamicProxy2;
using intercept.App_Start;

namespace intercept.Models
{
   // [Intercept(typeof(CallLogger))]
    public class SomeType : ISomeType
    {
        public void Show()
        {
            Debug.WriteLine("dzialam...");
        }
    }
}