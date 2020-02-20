using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaterializeCss.Startup))]
namespace MaterializeCss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
