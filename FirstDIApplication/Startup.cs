using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstDIApplication.Startup))]
namespace FirstDIApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
