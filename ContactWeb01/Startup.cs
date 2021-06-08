using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactWeb01.Startup))]
namespace ContactWeb01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
