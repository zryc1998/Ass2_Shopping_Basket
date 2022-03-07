using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ass2_Shopping_Basket.Startup))]
namespace Ass2_Shopping_Basket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
