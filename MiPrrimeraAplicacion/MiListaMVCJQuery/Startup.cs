using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiListaMVCJQuery.Startup))]
namespace MiListaMVCJQuery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
