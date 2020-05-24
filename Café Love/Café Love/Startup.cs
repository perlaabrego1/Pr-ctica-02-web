using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Café_Love.Startup))]
namespace Café_Love
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
