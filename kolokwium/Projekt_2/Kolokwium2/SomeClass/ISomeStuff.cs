using Autofac.Extras.DynamicProxy2;

namespace SomeClass
{
    //[Intercept("log-time")]
    public interface ISomeStuff
    {
        void MakeSomeWork();
    }
}
