using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoGameStoreWebsite.Startup))]
namespace VideoGameStoreWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
