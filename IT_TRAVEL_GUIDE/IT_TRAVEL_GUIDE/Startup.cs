using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_TRAVEL_GUIDE.Startup))]
namespace IT_TRAVEL_GUIDE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
