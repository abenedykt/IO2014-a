using System;
using System.Threading;
using Zad2MVC.Abstractions;


namespace Zad2Klas
{
    public class SomeLongRunningStuff : ISomeStuff
    {
        public void MakeSomeWork()
        {
            Thread.Sleep(10000);
        }
    }
}
