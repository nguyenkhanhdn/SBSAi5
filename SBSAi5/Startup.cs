using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SBSAi5.Startup))]
namespace SBSAi5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
