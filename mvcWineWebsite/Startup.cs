using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcWineWebsite.Startup))]
namespace mvcWineWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
