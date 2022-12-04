using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSiteForAzure2019.Startup))]
namespace WebSiteForAzure2019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
