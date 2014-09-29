using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewProfit.Startup))]
namespace NewProfit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
