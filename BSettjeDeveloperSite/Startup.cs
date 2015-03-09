using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSettjeDeveloperSite.Startup))]
namespace BSettjeDeveloperSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
