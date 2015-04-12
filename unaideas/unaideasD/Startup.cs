using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unaideasD.Startup))]
namespace unaideasD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
