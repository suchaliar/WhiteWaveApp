using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhiteWaveApp.Startup))]
namespace WhiteWaveApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
