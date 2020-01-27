using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Diplomado_Web_MVC_Consultorio_Medico.Startup))]
namespace Diplomado_Web_MVC_Consultorio_Medico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
