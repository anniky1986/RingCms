using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RingCms.Web.Startup))]
namespace RingCms.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
