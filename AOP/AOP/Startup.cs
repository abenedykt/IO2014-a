using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AOP.Startup))]
namespace AOP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
