using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labtracker.Startup))]
namespace Labtracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
