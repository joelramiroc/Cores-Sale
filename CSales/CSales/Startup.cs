using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSales.Startup))]
namespace CSales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
