using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlucoControl.Startup))]

namespace GlucoControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}