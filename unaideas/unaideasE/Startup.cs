using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unaideasE.Startup))]
namespace unaideasE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
