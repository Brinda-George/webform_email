using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webform1.Startup))]
namespace Webform1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
