using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iBook.WebUI.Startup))]
namespace iBook.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
