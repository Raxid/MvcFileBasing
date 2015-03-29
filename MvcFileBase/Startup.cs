using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcFileBasing.Startup))]
namespace MvcFileBasing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
