using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChiookWeb.Startup))]
namespace ChiookWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
