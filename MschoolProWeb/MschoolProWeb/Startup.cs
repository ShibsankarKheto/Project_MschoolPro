using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MschoolProWeb.Startup))]
namespace MschoolProWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
