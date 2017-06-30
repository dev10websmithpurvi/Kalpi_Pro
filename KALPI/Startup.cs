using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KALPI.Startup))]
namespace KALPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
