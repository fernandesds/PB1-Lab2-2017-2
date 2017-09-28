using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaAvaliativaLab2.Startup))]
namespace ProvaAvaliativaLab2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
