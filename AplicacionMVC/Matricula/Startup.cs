using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Matricula.Startup))]
namespace Matricula
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
