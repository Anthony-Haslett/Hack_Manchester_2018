using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hack_Manchester.Startup))]
namespace Hack_Manchester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
