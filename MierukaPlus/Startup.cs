using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MierukaPlus.Startup))]
namespace MierukaPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
