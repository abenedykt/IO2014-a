using System;
using Castle;

namespace ExampleClass
{
    public interface IData
    {
        string ValueA();
    }
    [Intercept("log-data")]
    public class Data : IData
    {
        private const int A = 10;

        public string ValueA()
        {
            return String.Format("Masz {0} błędów!", A);
        }
    }
}
