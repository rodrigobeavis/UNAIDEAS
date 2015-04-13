using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unaideas8.Startup))]
namespace unaideas8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
