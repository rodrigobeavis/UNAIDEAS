using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unaideasweb.Startup))]
namespace unaideasweb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
