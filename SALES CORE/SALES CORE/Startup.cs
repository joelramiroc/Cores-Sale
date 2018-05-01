using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SALES_CORE.Startup))]
namespace SALES_CORE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
