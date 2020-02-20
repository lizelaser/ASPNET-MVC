using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiCodeFirst.Startup))]
namespace MiCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
