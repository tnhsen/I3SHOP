using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(I3SHOP.Startup))]
namespace I3SHOP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
