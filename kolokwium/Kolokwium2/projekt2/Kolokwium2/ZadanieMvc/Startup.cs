using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZadanieMvc.Startup))]
namespace ZadanieMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
