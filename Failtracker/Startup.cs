using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Failtracker.Startup))]
namespace Failtracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
