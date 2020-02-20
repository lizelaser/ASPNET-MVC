using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiSeguridadMVC.Startup))]
namespace MiSeguridadMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
