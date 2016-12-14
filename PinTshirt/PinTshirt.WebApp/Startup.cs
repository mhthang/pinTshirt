using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PinTshirt.WebApp.Startup))]
namespace PinTshirt.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
