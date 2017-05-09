using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleCrudApp.Startup))]
namespace SampleCrudApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
