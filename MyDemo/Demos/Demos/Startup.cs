using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demos.Startup))]
namespace Demos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
