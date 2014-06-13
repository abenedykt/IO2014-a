using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project2.Interfaces;
using Project2.Vendors;
using System.Diagnostics;

namespace AutoFacMVC.Vendors
{
    public class SandBox : ISomeStuff
    {

        private ISomeStuff _stuff;

        public SandBox()
        {
            _stuff = new SomeLongRunningStuff();
        }


        public void MakeSomeWork()
        {
            try
            {
                _stuff.MakeSomeWork();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }

        }

    }
}