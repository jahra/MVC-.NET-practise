using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPdotNETBlog.Startup))]
namespace ASPdotNETBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
