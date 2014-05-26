using System.Threading;

namespace SomeLongRunning
{
    public class SomeLongRunningStuff : ISomeStuff
    {

        public void MakeSomeWork()
        {
            Thread.Sleep(10000);
        }
    }

    public interface ISomeStuff
    {
        void MakeSomeWork();
    }
}
