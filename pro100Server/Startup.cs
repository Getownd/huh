using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pro100Server.Startup))]
namespace pro100Server
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
