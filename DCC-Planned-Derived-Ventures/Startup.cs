using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DCC_Planned_Derived_Ventures.Startup))]
namespace DCC_Planned_Derived_Ventures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
