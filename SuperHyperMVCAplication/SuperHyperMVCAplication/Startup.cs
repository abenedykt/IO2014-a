using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperHyperMVCAplication.Startup))]
namespace SuperHyperMVCAplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
