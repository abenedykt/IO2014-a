using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAutofac.Startup))]
namespace MvcAutofac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
