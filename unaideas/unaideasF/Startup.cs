using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unaideasF.Startup))]
namespace unaideasF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
