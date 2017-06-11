using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoDep.Startup))]
namespace AutoDep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
