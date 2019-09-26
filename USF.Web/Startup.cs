using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(USF.Web.Startup))]
namespace USF.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
