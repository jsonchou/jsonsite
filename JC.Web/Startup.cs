using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JC.Web.Startup))]
namespace JC.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
