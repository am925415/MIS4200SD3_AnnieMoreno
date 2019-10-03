using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200SD3_AnnieMoreno.Startup))]
namespace MIS4200SD3_AnnieMoreno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
