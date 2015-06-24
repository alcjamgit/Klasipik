using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Klasipik.Web.Startup))]
namespace Klasipik.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
