using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MixPanelCSharpAPI.Startup))]
namespace MixPanelCSharpAPI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
