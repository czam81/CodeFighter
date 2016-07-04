using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeFighter.Startup))]
namespace CodeFighter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
