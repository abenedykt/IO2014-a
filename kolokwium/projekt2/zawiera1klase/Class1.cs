using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zawiera1klase
{
    public interface ISomeStuff
    {
        void MakeSomeWork();
    }

    public interface ITimeCount
    {
        void Timer();
    }

    public class SomeLongRunningStuff : ISomeStuff
    {

        public void MakeSomeWork()
        {
            Thread.Sleep(10000);
        }

    }

    public class TimeCount : ITimeCount
        {
           public void Timer()
            {
                var stopWatch = new Stopwatch();
                
                stopWatch.Start();
                Thread.Sleep(10000);
                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                // Format and display the TimeSpan value. 
               Trace.WriteLine(String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds/10));          
           }
    }
}