using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesCore.Startup))]
namespace SalesCore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
