using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIITTEST.Startup))]
namespace NIITTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
