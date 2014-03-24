using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularZad1.Startup))]
namespace AngularZad1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
