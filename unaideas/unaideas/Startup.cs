using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unaideas.Startup))]
namespace unaideas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
