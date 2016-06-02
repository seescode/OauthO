using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OauthO.Startup))]
namespace OauthO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
