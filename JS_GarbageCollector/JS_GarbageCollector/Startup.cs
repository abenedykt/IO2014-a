using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JS_GarbageCollector.Startup))]
namespace JS_GarbageCollector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
