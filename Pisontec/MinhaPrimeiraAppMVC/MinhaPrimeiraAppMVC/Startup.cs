using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MinhaPrimeiraAppMVC.Startup))]
namespace MinhaPrimeiraAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
