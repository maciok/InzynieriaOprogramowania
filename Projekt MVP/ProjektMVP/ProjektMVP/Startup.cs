using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektMVP.Startup))]
namespace ProjektMVP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
