using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeMatch.Startup))]
namespace LifeMatch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
