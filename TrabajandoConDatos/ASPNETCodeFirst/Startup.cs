using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNETCodeFirst.Startup))]
namespace ASPNETCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
