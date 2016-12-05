using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectIHFF.Startup))]
namespace ProjectIHFF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
