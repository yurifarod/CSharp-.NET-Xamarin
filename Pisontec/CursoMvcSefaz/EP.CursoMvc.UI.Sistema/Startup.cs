using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EP.CursoMvc.UI.Sistema.Startup))]
namespace EP.CursoMvc.UI.Sistema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
