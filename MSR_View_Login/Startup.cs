using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSR_Web_App.Startup))]
namespace MSR_Web_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
