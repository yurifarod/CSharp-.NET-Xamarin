using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEFAZ.CursoMvc.UI.Startup))]
namespace SEFAZ.CursoMvc.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
