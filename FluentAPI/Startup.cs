using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FluentAPI.Startup))]
namespace FluentAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
