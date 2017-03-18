using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySoft.Startup))]
namespace MySoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
