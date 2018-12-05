using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminLteTest.Startup))]
namespace AdminLteTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
