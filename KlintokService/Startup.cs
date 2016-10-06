using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(KlintokService.Startup))]

namespace KlintokService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}