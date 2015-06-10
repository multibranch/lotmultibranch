using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lottomultibranch.Startup))]
namespace Lottomultibranch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
