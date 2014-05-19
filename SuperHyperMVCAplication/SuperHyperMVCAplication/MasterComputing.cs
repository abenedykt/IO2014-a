using Autofac.Extras.DynamicProxy2;
using SuperHyperMVCAplication.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperHyperMVCAplication
{
    public interface IMasterComputing
    {
        void ComputeSomeSheet(int i);
    }

    [Intercept(typeof(CallLogger))]
    public class MasterComputing : IMasterComputing
    {

        public void ComputeSomeSheet(int id)
        {
            for (int i = 0; i < id; i++)
            {
                var z = id * i;
            }
        }
    }
}