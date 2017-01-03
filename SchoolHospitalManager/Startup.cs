using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolHospitalManager.Startup))]
namespace SchoolHospitalManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
