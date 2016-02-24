using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ass4AllTogether.Startup))]
namespace Ass4AllTogether
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
