using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RasporedApp.Startup))]
namespace RasporedApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
