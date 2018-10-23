using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimplifiedLogin.Startup))]
namespace SimplifiedLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
