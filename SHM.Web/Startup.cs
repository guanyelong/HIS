using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SHM.Web.Startup))]
namespace SHM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
