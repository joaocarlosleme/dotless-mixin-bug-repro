using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVC5Net4dot6.Startup))]
namespace TestMVC5Net4dot6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
