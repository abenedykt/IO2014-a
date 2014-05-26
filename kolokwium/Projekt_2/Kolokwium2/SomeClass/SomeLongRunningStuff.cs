using System.Threading;
using Autofac.Extras.DynamicProxy2;

namespace SomeClass
{
    public class SomeLongRunningStuff : ISomeStuff
    {        
        public void MakeSomeWork()
        {
            Thread.Sleep(10000);
        }
    }
}