using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMvcAPI.Startup))]
namespace WebMvcAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
