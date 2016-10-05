using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AntBoxRepots.Startup))]
namespace AntBoxRepots
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
