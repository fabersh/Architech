using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Architech.Startup))]
namespace Architech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
