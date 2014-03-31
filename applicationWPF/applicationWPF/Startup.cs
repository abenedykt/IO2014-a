using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(applicationWPF.Startup))]
namespace applicationWPF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
