using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Print_PDF.Startup))]
namespace MVC_Print_PDF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
