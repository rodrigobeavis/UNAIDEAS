using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unaideas7.Startup))]
namespace unaideas7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
