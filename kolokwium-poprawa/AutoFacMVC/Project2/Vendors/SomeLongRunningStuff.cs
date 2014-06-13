using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project2.Interfaces;
using System.Threading;

namespace Project2.Vendors
{
    public class SomeLongRunningStuff : ISomeStuff
    {
        			public void MakeSomeWork()
                        {
				             Thread.Sleep(10000);
                             throw new Exception("catch me if you can");
			            }
    }
}