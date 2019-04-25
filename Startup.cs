using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(class1.Startup))]
namespace class1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
