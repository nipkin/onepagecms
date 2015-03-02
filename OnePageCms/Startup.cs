using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnePageCms.Startup))]
namespace OnePageCms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
